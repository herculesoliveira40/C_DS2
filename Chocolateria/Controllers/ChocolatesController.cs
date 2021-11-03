using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chocolateria.Models;

namespace Chocolateria.Controllers
{
    public class ChocolatesController : Controller
    {
        private readonly ChocolateriaContext _context;

        public ChocolatesController(ChocolateriaContext context)
        {
            _context = context;
        }

        // GET: Chocolates

        public async Task<IActionResult> Index()           ////////////////////////////////// Aleluia
        {
            ViewBag.msg = "Exibe Todos Chocolates  ";
            List<Chocolate> chocolatescadastrados = _context.Chocolates.ToList(); // Sem where
            return View(chocolatescadastrados);
        }        
        public async Task<IActionResult> AreaRestrita()
        {
            return View(await _context.Chocolates.ToListAsync());
        }
 
        public async Task<IActionResult> Gourmet()          
        {
            ViewBag.msg = "Exibe Chocolates Gourmet ( Valor maior que 50 R$) ";
            List<Chocolate> chocolatesgourmet = _context.Chocolates.Where( c => c.Valor_Chocolate >= 50).ToList();
            return View(chocolatesgourmet);
        }                                                      

        // GET: Chocolates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates
                .FirstOrDefaultAsync(m => m.id_Chocolate == id);
            if (chocolate == null)
            {
                return NotFound();
            }

            return View(chocolate);
        }

        // GET: Chocolates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chocolates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_Chocolate,Valor_Chocolate,Quantidade_Disponivel,Peso_Chocolate,Marca_Chocolate,Porcentagem_Cacau,Tipo_Chocolate,Data_Validade,Cupom_Desconto")] Chocolate chocolate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chocolate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AreaRestrita));
            }
            return View(chocolate);
        }

        // GET: Chocolates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates.FindAsync(id);
            if (chocolate == null)
            {
                return NotFound();
            }
            return View(chocolate);
        }

        // POST: Chocolates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_Chocolate,Valor_Chocolate,Quantidade_Disponivel,Peso_Chocolate,Marca_Chocolate,Porcentagem_Cacau,Tipo_Chocolate,Data_Validade,Cupom_Desconto")] Chocolate chocolate)
        {
            if (id != chocolate.id_Chocolate)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chocolate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChocolateExists(chocolate.id_Chocolate))
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
            return View(chocolate);
        }

        // GET: Chocolates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chocolate = await _context.Chocolates
                .FirstOrDefaultAsync(m => m.id_Chocolate == id);
            if (chocolate == null)
            {
                return NotFound();
            }

            return View(chocolate);
        }

        // POST: Chocolates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chocolate = await _context.Chocolates.FindAsync(id);
            _context.Chocolates.Remove(chocolate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AreaRestrita));
        }

        private bool ChocolateExists(int id)
        {
            return _context.Chocolates.Any(e => e.id_Chocolate == id);
        }
    }
}
