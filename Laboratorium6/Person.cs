using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<Book> BorrowedBooks { get; set; }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Book book)
    {
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(Book book)
    {
        BorrowedBooks.Remove(book);
    }
}
