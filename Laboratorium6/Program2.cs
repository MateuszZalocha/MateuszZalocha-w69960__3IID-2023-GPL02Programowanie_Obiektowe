using System.Collections.Generic;
using System.Linq;

public class BookRepository : IBookRepository
{
    private List<Book> books;

    public BookRepository()
    {
        books = new List<Book>();
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        return books.Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Book> GetBooksByYear(int year)
    {
        return books.Where(book => book.Year == year).ToList();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }
}
