using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookLending.Classes;

namespace BookLending.Repository
{
    public partial class BookRepository:EntityRepository
    {

        public BookRepository(string direction =""):base(direction)
        {
            
        }

        Dictionary<int, Book> books = new Dictionary<int, Book>();
        List<EditionBooks> editionBooks = new List<EditionBooks>();
        Dictionary<int, Person> persons = new Dictionary<int, Person>();
        Dictionary<int, BookList> bookLists = new Dictionary<int, BookList>();
        Dictionary<int, Edition> editions = new Dictionary<int, Edition>();
        List<FuncPerson> funcPersons = new List<FuncPerson>();
        Dictionary<int, Function> functions = new Dictionary<int, Function>();
        Dictionary<int, Genre> genres = new Dictionary<int, Genre>();
        Dictionary<int, Librarian> librarians = new Dictionary<int, Librarian>();
        List<Order> orders = new List<Order>();
        Dictionary<int, Reader> readers = new Dictionary<int, Reader>();

        public void ClearAllLists()
        {
            books.Clear();
            editionBooks.Clear();
            persons.Clear();
            bookLists.Clear();
            editions.Clear();
            funcPersons.Clear();
            functions.Clear();
            genres.Clear();
            librarians.Clear();
            orders.Clear();
            readers.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Предметна область: Видача книг");
            sb.Append(Book.ToStringExt("\n     Книги"));
            sb.Append(Genre.ToStringExt("\n     Жанри"));
            sb.Append(Edition.ToStringExt("\n     Видавництва"));
            sb.Append(Order.ToStringExt("\n     Замовлення"));
            sb.Append(BookList.ToStringExt("\n     Списки книг"));
            sb.Append(Librarian.ToStringExt("\n     Бібліотекарі"));
            sb.Append(Reader.ToStringExt("\n     Читачі"));
            sb.Append(Function.ToStringExt("\n     Функції"));
            sb.Append(Person.ToStringExt("\n     Персони"));

            return sb.ToString();
        }
        public Book[] Book
        {
            get { return books.Select(e => e.Value).ToArray(); }
        }

        public EditionBooks[] EditionBooks
        {
            get { return editionBooks.ToArray(); }
        }

        public Person[] Person
        {
            get { return persons.Select(e => e.Value).ToArray(); }
        }

        public BookList[] BookList
        {
            get { return bookLists.Select(e => e.Value).ToArray(); }
        }

        public Edition[] Edition
        {
            get { return editions.Select(e => e.Value).ToArray(); }
        }

        public FuncPerson[] FuncPerson
        {
            get { return funcPersons.ToArray(); }
        }

        public Function[] Function
        {
            get { return functions.Select(e => e.Value).ToArray(); }
        }

        public Genre[] Genre
        {
            get { return genres.Select(e => e.Value).ToArray(); }
        }

        public Librarian[] Librarian
        {
            get { return librarians.Select(e => e.Value).ToArray(); }
        }

        public Order[] Order
        {
            get { return orders.ToArray(); }
        }

        public Reader[] Reader
        {
            get { return readers.Select(e => e.Value).ToArray(); }
        }
    }
}
