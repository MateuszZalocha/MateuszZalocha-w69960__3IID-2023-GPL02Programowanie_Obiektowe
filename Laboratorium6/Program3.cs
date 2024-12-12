using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        PersonRepository personRepo = new PersonRepository();
        BookRepository bookRepo = new BookRepository();

        
        Book book1 = new Book("Book 1", "Author 1", 2020);
        Book book2 = new Book("Book 2", "Author 2", 2021);
        Book book3 = new Book("Book 3", "Author 1", 2022);

        
        bookRepo.AddBook(book1);
        bookRepo.AddBook(book2);
        bookRepo.AddBook(book3);

        
        Person person = new Person("John", "Doe");

        
        personRepo.AddPerson(person);

        
        personRepo.AddBookToPersonBorrowedBooks(person, book1);
        personRepo.AddBookToPersonBorrowedBooks(person, book3);

        
        Console.WriteLine("Books borrowed by " + person.Name + ":");
        foreach (var borrowedBook in personRepo.GetBooksBorrowedByPerson(person))
        {
            Console.WriteLine(borrowedBook.Title);
        }

        
        Console.WriteLine("\nBooks by Author 1:");
        foreach (var bookByAuthor in bookRepo.GetBooksByAuthor("Author 1"))
        {
            Console.WriteLine(bookByAuthor.Title);
        }

        
        Console.WriteLine("\nBooks published in 2020:");
        foreach (var bookByYear in bookRepo.GetBooksByYear(2020))
        {
            Console.WriteLine(bookByYear.Title);
        }
    }
}
