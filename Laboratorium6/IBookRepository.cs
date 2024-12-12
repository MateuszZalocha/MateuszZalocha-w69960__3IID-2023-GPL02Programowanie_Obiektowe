using System.Collections.Generic;

public interface IBookRepository
{
    List<Book> GetAllBooks();
    List<Book> GetBooksByAuthor(string author);
    List<Book> GetBooksByYear(int year);
}
