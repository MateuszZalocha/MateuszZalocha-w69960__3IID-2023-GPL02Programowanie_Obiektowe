using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppli.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class lab7Controller : ControllerBase
    {
        private readonly IBookRepository repository;

        public lab7Controller()
        {
            repository = new BookRepository();
        }

        [HttpGet]
        public List<Book> GetAllBooks()
        {
            return repository.GetAllBooks();
        }

        public IBookRepository GetRepository()
        {
            return repository;
        }

        [HttpPost]
        public bool AddBook(Book book, IBookRepository repository)
        {
            Add(book);
            return true;
        }

        private void Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
