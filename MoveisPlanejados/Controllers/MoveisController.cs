using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoveisPlanejados.Models;

namespace MoveisPlanejados.Controllers
{
    public class MoveisController : Controller
    {
        private readonly MoveisContext _context;

        public MoveisController(MoveisContext context)
        {
            _context = context;
        }

        // GET: Moveis
        public async Task<IActionResult> Index()
        {
            var moveisContext = _context.Moveis.Include(m => m.Funcionario);
            return View(await moveisContext.ToListAsync());
        }
        public async Task<IActionResult> AreaRestrita()
        {
            var moveisContext = _context.Moveis.Include(m => m.Funcionario);
            return View(await moveisContext.ToListAsync());
        }
        // GET: Moveis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .Include(m => m.Funcionario)
                .FirstOrDefaultAsync(m => m.Id_Movel == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // GET: Moveis/Create
        public IActionResult Create()
        {
            // var funcionario_disponivel = _context.Funcionarios.Where(f => f.Status_Funcionario == "Disponivel");
            // ViewData["FuncionarioId"] = new SelectList(funcionario_disponivel, "FuncionarioId", "Nome_Funcionario");
             var funcionario_primeiro = _context.Funcionarios.Where(f => f.FuncionarioId == 1);
             ViewData["FuncionarioId"] = new SelectList(funcionario_primeiro, "FuncionarioId", "Nome_Funcionario");
            return View();
        }

        // POST: Moveis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Movel,Nome_Cliente,Nome_Movel,Cor_Movel,Medidas_Movel,Material_Movel,Valor_Movel,Imagem_Movel,Status_Movel,FuncionarioId")] Movel movel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          //  ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "FuncionarioId", "Nome_Funcionario", movel.FuncionarioId);
             var funcionario_primeiro = _context.Funcionarios.Where(f => f.FuncionarioId == 1);
             ViewData["FuncionarioId"] = new SelectList(funcionario_primeiro, "FuncionarioId", "Nome_Funcionario");          
            return View(movel);
        }

        // GET: Moveis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis.FindAsync(id);
            if (movel == null)
            {
                return NotFound();
            }
            var funcionario_disponivel = _context.Funcionarios.Where(f => f.Status_Funcionario == "Disponivel");
            ViewData["FuncionarioId"] = new SelectList(funcionario_disponivel, "FuncionarioId", "Nome_Funcionario", movel.FuncionarioId);
          //  ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "FuncionarioId", "Nome_Funcionario", movel.FuncionarioId);
            return View(movel);
        }

        // POST: Moveis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Movel,Nome_Cliente,Nome_Movel,Cor_Movel,Medidas_Movel,Material_Movel,Valor_Movel,Imagem_Movel,Status_Movel,FuncionarioId")] Movel movel)
        {
            if (id != movel.Id_Movel)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (movel.Status_Movel == "Entregue")
                    {
                      Funcionario funcionario = _context.Funcionarios.Find(movel.FuncionarioId);
                    funcionario.Status_Funcionario = "Disponivel";
                    _context.Update(funcionario);
                    }
                    else if (movel.Status_Movel == "Em_Construcao")
                    {
                        Funcionario funcionario = _context.Funcionarios.Find(movel.FuncionarioId);
                        funcionario.Status_Funcionario = "Indisponivel";
                        _context.Update(funcionario);
                    }
                    _context.Update(movel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovelExists(movel.Id_Movel))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(AreaRestrita));
            }
            ViewData["FuncionarioId"] = new SelectList(_context.Funcionarios, "FuncionarioId", "Nome_Funcionario", movel.FuncionarioId);
            return View(movel);
        }

        // GET: Moveis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movel = await _context.Moveis
                .Include(m => m.Funcionario)
                .FirstOrDefaultAsync(m => m.Id_Movel == id);
            if (movel == null)
            {
                return NotFound();
            }

            return View(movel);
        }

        // POST: Moveis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movel = await _context.Moveis.FindAsync(id);
            _context.Moveis.Remove(movel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AreaRestrita));
        }

        private bool MovelExists(int id)
        {
            return _context.Moveis.Any(e => e.Id_Movel == id);
        }
    }
}
