using Microsoft.EntityFrameworkCore;

namespace Curriculos.Models

{
    public class CurriculosContext : DbContext
    {
    public  CurriculosContext(DbContextOptions<CurriculosContext> options) : base(options){

     }
        public DbSet<Curriculo> Curriculos { get; set; }

    
    }
}