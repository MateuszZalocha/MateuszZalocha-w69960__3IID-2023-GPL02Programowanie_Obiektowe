
using System;

using System.Collections.Generic;
using System.Linq;

public class PersonRepository : IPersonRepository
{
    private List<Person> persons;

    public PersonRepository()
    {
        persons = new List<Person>();
    }

    public List<Person> GetAllPersons()
    {
        return persons;
    }

    public Person GetPersonByName(string name)
    {
        return persons.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> GetBooksBorrowedByPerson(Person person)
    {
        return person.BorrowedBooks;
    }

    public void AddBookToPersonBorrowedBooks(Person person, Book book)
    {
        person.BorrowBook(book);
    }

    public void AddPerson(Person person)
    {
        persons.Add(person);
    }
}
