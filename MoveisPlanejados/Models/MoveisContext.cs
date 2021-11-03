using Microsoft.EntityFrameworkCore;

namespace MoveisPlanejados.Models
{
    public class MoveisContext : DbContext
    {
    public  MoveisContext(DbContextOptions<MoveisContext> options) : base(options){

     }
        public DbSet<Movel> Moveis { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

    
    }
}