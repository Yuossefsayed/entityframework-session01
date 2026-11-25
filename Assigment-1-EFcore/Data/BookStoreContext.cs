
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using BookStore.Entities;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
        {
        }

        public BookStoreContext(
            DbContextOptions<BookStoreContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=BookStoreDB;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}

