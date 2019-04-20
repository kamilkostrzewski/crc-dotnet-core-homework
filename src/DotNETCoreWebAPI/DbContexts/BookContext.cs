using DotNETCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNETCoreWebAPI.DbContexts
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Measurements { get; set; }
    }
}
