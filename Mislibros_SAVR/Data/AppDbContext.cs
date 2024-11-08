using Microsoft.EntityFrameworkCore;
using Mislibros_SAVR.Data.Models;
namespace Mislibros_SAVR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }

        public DbSet<Books> Books { get; set; }
    }
}
