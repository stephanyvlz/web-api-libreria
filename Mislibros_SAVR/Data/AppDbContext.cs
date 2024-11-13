using Microsoft.EntityFrameworkCore;
using Mislibros_SAVR.Data.Models;
namespace Mislibros_SAVR.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Author>()
                .HasOne(b => b.Book)
                .WithMany(ba => ba.Books_Authors)
                .HasForeignKey(bi => bi.BookId);
            modelBuilder.Entity<Book_Author>()
            .HasOne(b => b.Author)
            .WithMany(ba => ba.Books_Authors)
            .HasForeignKey(bi => bi.AuthorId);
        }
        public DbSet<Books> Books { get; set; }
        protected DbSet<Author> Authors { get; set; }
        protected DbSet<Book_Author> Book_Authors { get; set; }
        protected DbSet<Publisher> Publishers { get; set; }

    }
}
