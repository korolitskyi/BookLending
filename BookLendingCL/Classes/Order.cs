using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Order : Entity
    {
        public int NumberOfOrder { get; set; }
        public int LibrarianId { get; set; }
        public int BookListId { get; set; }
        public int ReaderId { get; set; }        
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfAdmission { get; set; }

        internal Librarian Librarian { get; set; }
        internal BookList BookList { get; set; }
        internal Reader Reader { get; set; }

        public override string ToString()
        {
            return String.Format("Номер замовлення: {0}\tБібліотекар: {1} {2}\tСписок книг: {3}\tЧитач: {4} {5}\tДата видачі: {6}\tДата здачі: {7}\n\n"
                , NumberOfOrder, Librarian.Person.FirstName, Librarian.Person.LastName, BookList.NumberOfBooks, Reader.Person.FirstName, Reader.Person.LastName, DateOfIssue.ToShortDateString(), DateOfAdmission.ToShortDateString());
        }
    }
}
