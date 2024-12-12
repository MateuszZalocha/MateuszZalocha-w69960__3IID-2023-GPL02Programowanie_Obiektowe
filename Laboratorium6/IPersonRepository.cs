using System;
using System.Collections.Generic;

public interface IPersonRepository
{
    List<Person> GetAllPersons();
    Person GetPersonByName(string name);
    List<Book> GetBooksBorrowedByPerson(Person person);
    void AddBookToPersonBorrowedBooks(Person person, Book book);
}
