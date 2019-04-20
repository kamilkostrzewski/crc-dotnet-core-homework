using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreWebAPI.Models;
using DotNETCoreWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DotNETCoreWebAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository<Book> _bookRepository;

        public BookController(IBookRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await _bookRepository.GetAll();

            return Ok(books);
        }

        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            var book = await _bookRepository.Get(id);
            if (book == null)
            {
                return NotFound("The book record couldn't be found");
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Book book)
        {
            await _bookRepository.Add(book);
            if (book == null)
            {
                return BadRequest("The book is null");
            }

            return CreatedAtAction(nameof(Get), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, Book book)
        {
            var bookToUpdate = await _bookRepository.Get(id);
            await _bookRepository.Update(bookToUpdate, book);
            if (bookToUpdate == null)
            {
                return NotFound("The book record couldn't be found");
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var bookToDelete = await _bookRepository.Get(id);
            await _bookRepository.Delete(bookToDelete);

            return NoContent();
        }
    }
}