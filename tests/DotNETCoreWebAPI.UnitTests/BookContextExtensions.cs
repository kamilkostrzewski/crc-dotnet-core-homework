using DotNETCoreWebAPI.DbContexts;
using DotNETCoreWebAPI.Models;

namespace DotNETCoreWebAPI.UnitTests
{
    public static class BookContextExtensions
    {
        public static void FillDatabase(this BookContext dbContext)
        {
            dbContext.Books.Add
            (
                new Book
                {
                    Id = 1,
                    Title = "Book_01",
                    Author = "Author_01",
                    ISBN = "0228260269",
                    Year = 2000
                }
            );

            dbContext.Add
            (
                new Book
                {
                    Id = 2,
                    Title = "Book_02",
                    Author = "Author_02",
                    ISBN = "0618233269",
                    Year = 2001
                }
            );

            dbContext.Add
            (
                new Book
                {
                    Id = 3,
                    Title = "Book_03",
                    Author = "Author_03",
                    ISBN = "0618264469",
                    Year = 2002
                }
            );

            dbContext.Add
            (
                new Book
                {
                    Id = 4,
                    Title = "Book_04",
                    Author = "Author_04",
                    ISBN = "0618260233",
                    Year = 2000
                }
            );

            dbContext.Add
            (
                new Book
                {
                    Id = 5,
                    Title = "Book_05",
                    Author = "Author_05",
                    ISBN = "0618260559",
                    Year = 2010
                }
            );

            dbContext.SaveChanges();
        }
    }
}
