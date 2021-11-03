using Microsoft.EntityFrameworkCore;

namespace Chocolateria.Models
{
    public class ChocolateriaContext : DbContext
    {
    public  ChocolateriaContext(DbContextOptions<ChocolateriaContext> options) : base(options){

     }
        public DbSet<Chocolate> Chocolates { get; set; }
    
    }
}