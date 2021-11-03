using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Models
{
    public class Press_CoffeContext: DbContext
    {
        public Press_CoffeContext(DbContextOptions<Press_CoffeContext> options) : base(options){

        }
      public DbSet<Cafe> Cafes { get; set; }
    }
}