using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppli.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class labpersonController : ControllerBase
    {
        private readonly IPersonRepository repository;

        public labpersonController()
        {
            repository = new PersonRepository();
        }

        [HttpGet]
        public List<Person> GetAllPersons()
        {
            return repository.GetAllPersons();
        }

        public IPersonRepository GetRepository()
        {
            return repository;
        }

        [HttpPost]
        public bool AddBookToPersonBorrowedBooks(Person person, Book book)
        {
            repository.AddBookToPersonBorrowedBooks(person, book);
            return true;
        }
    }
}

