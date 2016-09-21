using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using BookLending.Classes;

namespace BookLending.Repository {

    public partial class BookRepository {

        protected override void FillCollections(DataSet ds) {
            ClearAllLists();
            FillBook(ds);
            FillEditionBooks(ds);
            FillPerson(ds);
            FillBookList(ds);
            FillEdition(ds);
            FillFuncPerson(ds);
            FillFunction(ds);
            FillGenre(ds);
            FillOrder(ds);
            FillLibrarian(ds);
            FillReader(ds);

            CreateObjectLinks();
        }

        private bool FillBook(DataSet ds) {
            if (!ds.Tables.Contains("Book"))
                return false;
            foreach (DataRow dr in ds.Tables["Book"].Rows) {
                Book obj = new Book();
                FillEntityMembers(dr, obj);
                obj.GenreId = Int32.Parse(dr["GenreId"].ToString());
                //obj.UNNumericCode = dr["UNNumericCode"].ToString();
                this.books[obj.Id] = obj;
            }
            return true;
        }

        private bool FillEditionBooks(DataSet ds)
        {
            if (!ds.Tables.Contains("EditionBooks"))
                return false;
            foreach (DataRow dr in ds.Tables["EditionBooks"].Rows)
            {
                EditionBooks obj = new EditionBooks();
                //FillEntityMembers(dr, null);
                obj.EditionId = Int32.Parse(dr["EditionId"].ToString());
                obj.BookId = Int32.Parse(dr["BookId"].ToString());
                this.editionBooks.Add(obj);
            }
            return true;
        }

        private bool FillPerson(DataSet ds) {
            if (!ds.Tables.Contains("Person"))
                return false;
            foreach (DataRow dr in ds.Tables["Person"].Rows) {
                Person obj = new Person();
                FillEntityMembers(dr, obj);
                obj.FirstName = dr["FirstName"].ToString();
                obj.LastName = dr["Lastname"].ToString();
                this.persons[obj.Id] = obj;
            }
            return true;
        }

        private bool FillBookList(DataSet ds) {
            if (!ds.Tables.Contains("BookList"))
                return false;
            foreach (DataRow dr in ds.Tables["BookList"].Rows) {
                BookList obj =  new BookList();
                FillEntityMembers(dr, obj);
                obj.BookId = Int32.Parse(dr["BookId"].ToString());
                obj.NumberOfBooks = Int32.Parse(dr["NumberOfBooks"].ToString());
                this.bookLists[obj.Id] = obj;
            }
            return true;
        }

        private bool FillEdition(DataSet ds)
        {
            if (!ds.Tables.Contains("Edition"))
                return false;
            foreach (DataRow dr in ds.Tables["Edition"].Rows)
            {
                Edition obj = new Edition();
                FillEntityMembers(dr, obj);
                this.editions[obj.Id] = obj;
            }
            return true;
        }

        private bool FillFuncPerson(DataSet ds)
        {
            if (!ds.Tables.Contains("FuncPerson"))
                return false;
            foreach (DataRow dr in ds.Tables["FuncPerson"].Rows)
            {
                FuncPerson obj = new FuncPerson();
                //FillEntityMembers(dr, null);
                obj.BookId = Int32.Parse(dr["BookId"].ToString());
                obj.PersonId = Int32.Parse(dr["PersonId"].ToString());
                obj.FunctionId = Int32.Parse(dr["FunctionId"].ToString());
                this.funcPersons.Add(obj);
            }
            return true;
        }

        private bool FillFunction(DataSet ds)
        {
            if (!ds.Tables.Contains("Function"))
                return false;
            foreach (DataRow dr in ds.Tables["Function"].Rows)
            {
                Function obj = new Function();
                FillEntityMembers(dr, obj);
                this.functions[obj.Id] = obj;
            }
            return true;
        }

        private bool FillGenre(DataSet ds)
        {
            if (!ds.Tables.Contains("Genre"))
                return false;
            foreach (DataRow dr in ds.Tables["Genre"].Rows)
            {
                Genre obj = new Genre();
                FillEntityMembers(dr, obj);
                this.genres[obj.Id] = obj;
            }
            return true;
        }

        private bool FillLibrarian(DataSet ds)
        {
            if (!ds.Tables.Contains("Librarian"))
                return false;
            foreach (DataRow dr in ds.Tables["Librarian"].Rows)
            {
                Librarian obj = new Librarian();
                FillEntityMembers(dr, obj);
                obj.PersonId = Int32.Parse(dr["PersonId"].ToString());
                obj.Ocupation = dr["Ocupation"].ToString();
                this.librarians[obj.Id] = obj;
            }
            return true;
        }

        private bool FillOrder(DataSet ds)
        {
            if (!ds.Tables.Contains("Order"))
                return false;
            foreach (DataRow dr in ds.Tables["Order"].Rows)
            {
                Order obj = new Order();
                FillEntityMembers(dr, obj);
                obj.NumberOfOrder = Int32.Parse(dr["NumberOfOrder"].ToString());
                obj.LibrarianId = Int32.Parse(dr["LibrarianId"].ToString());
                obj.BookListId = Int32.Parse(dr["BooklistId"].ToString());
                obj.ReaderId = Int32.Parse(dr["ReaderId"].ToString());
                if (dr["DateOfIssue"].ToString() != "")
                {
                    obj.DateOfIssue = DateTime.Parse(dr["DateOfIssue"].ToString());
                }
                else
                {
                    obj.DateOfIssue = DateTime.Now;
                }
                if (dr["DateOfAdmission"].ToString() != "")
                {
                    obj.DateOfAdmission = DateTime.Parse(dr["DateOfAdmission"].ToString());
                }
                else
                {
                    obj.DateOfAdmission = DateTime.Now;
                }
                this.orders.Add(obj);
            }
            return true;
        }

        private bool FillReader(DataSet ds)
        {
            if (!ds.Tables.Contains("Reader"))
                return false;
            foreach (DataRow dr in ds.Tables["Reader"].Rows)
            {
                Reader obj = new Reader();
                FillEntityMembers(dr, obj);
                obj.NumberTicket = Int32.Parse(dr["NumberTicket"].ToString());
                obj.PersonId = Int32.Parse(dr["PersonId"].ToString());
                this.readers[obj.Id] = obj;
            }
            return true;
        }

        private void CreateObjectLinks()
        {
            CreateBookLinks();
            CreateBookListLinks();
            CreateEditionBooksLinks();
            CreateFuncPersonLinks();
            CreateReaderLinks();
            CreateOrderLinks();
            CreateLibrarianLinks();
        }

        private void CreateBookLinks()
        {
            Book[] bookArray = books.Select(e => e.Value).ToArray();
            for (int i = 0; i < bookArray.Length; i++)
            {
                if (bookArray[i].GenreId == 0)
                    continue;
                bookArray[i].Genre = genres[bookArray[i].GenreId];
                bookArray[i].Genre.Books.Add(bookArray[i]);
            }
        }        

        private void CreateBookListLinks()
        {
            BookList[] bookListArray = bookLists.Select(e=>e.Value).ToArray();
            for (int i = 0; i < bookListArray.Length; i++)
            {
                if (bookListArray[i].BookId == 0)
                    continue;
                bookListArray[i].Book = books[bookListArray[i].BookId];
            }
        }

        private void CreateEditionBooksLinks()
        {
            EditionBooks[] editionBooksArray = editionBooks.ToArray();
            for (int i = 0; i < editionBooksArray.Length; i++)
            {                
                Book book = books[editionBooks[i].BookId];
                Edition edition = editions[editionBooks[i].EditionId];

                if (edition.Books == null)
                    edition.Books = new List<Book>();
                edition.Books.Add(book);

                if (book.Editions == null)
                    book.Editions = new List<Edition>();
                book.Editions.Add(edition);


            }
        }

        private void CreateFuncPersonLinks()
        {
            FuncPerson[] funcPersonArray = funcPersons.ToArray();
            for (int i = 0; i < funcPersonArray.Length; i++)
            {
                if (funcPersonArray[i].BookId != 0)
                {
                    funcPersonArray[i].Book = books[funcPersonArray[i].BookId];
                    funcPersonArray[i].Book.FuncPersons.Add(funcPersonArray[i]);
                }
                if (funcPersonArray[i].PersonId != 0)
                {
                    funcPersonArray[i].Person = persons[funcPersonArray[i].PersonId];
                    funcPersonArray[i].Person.FuncPersons.Add(funcPersonArray[i]);
                }
                if (funcPersonArray[i].FunctionId != 0)
                {
                    funcPersonArray[i].Function = functions[funcPersonArray[i].FunctionId];
                    funcPersonArray[i].Function.FuncPersons.Add(funcPersonArray[i]);
                }
            }
        }

        private void CreateReaderLinks()
        {
            Reader[] readerArray = readers.Select(e => e.Value).ToArray();
            for (int i = 0; i < readerArray.Length; i++)
            {
                if (readerArray[i].PersonId == 0)
                    continue;
                readerArray[i].Person = persons[readerArray[i].PersonId];
            }
        }

        private void CreateOrderLinks()
        {
            Order[] orderArray = orders.ToArray();
            for(int i = 0;i<orderArray.Length;i++)
            {
                if (orderArray[i].LibrarianId != 0)
                {
                    orderArray[i].Librarian = librarians[orderArray[i].LibrarianId];
                    orderArray[i].Librarian.Orders.Add(orderArray[i]);
                }
                if (orderArray[i].BookListId != 0)
                {
                    orderArray[i].BookList = bookLists[orderArray[i].BookListId];
                    orderArray[i].BookList.Orders.Add(orderArray[i]);
                }
                if (orderArray[i].ReaderId != 0)
                {
                    orderArray[i].Reader = readers[orderArray[i].ReaderId];
                    orderArray[i].Reader.Orders.Add(orderArray[i]);
                }
              
            }
        }

        private void CreateLibrarianLinks()
        {
            Librarian[] librarianArray = librarians.Select(e => e.Value).ToArray();
            for (int i = 0; i < librarianArray.Length; i++)
            {
                if (librarianArray[i].PersonId == 0)
                    continue;
                librarianArray[i].Person = persons[librarianArray[i].PersonId];
            }
            

            
        }
    }
}
