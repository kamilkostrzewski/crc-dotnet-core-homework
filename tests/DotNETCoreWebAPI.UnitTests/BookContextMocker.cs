using DotNETCoreWebAPI.DbContexts;
using DotNETCoreWebAPI.Models;
using DotNETCoreWebAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNETCoreWebAPI.UnitTests
{
    public static class BookContextMocker
    {
        public static IBookRepository<Book> GetInMemoryBookRepository(string dbName)
        {
            var options = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            BookContext bookContext = new BookContext(options);
            bookContext.FillDatabase();

            return new BookRepository(bookContext);
        }
    }
}
