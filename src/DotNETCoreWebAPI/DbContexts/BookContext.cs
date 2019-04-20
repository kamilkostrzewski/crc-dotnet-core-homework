using DotNETCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNETCoreWebAPI.DbContexts
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Homework.db");
        }
    }
}
