using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class BookList : IdentifiedEntity
    {
        public int NumberOfBooks { get; set; }
        public int BookId { get; set; }

        internal Book Book { get; set; }

        internal List<Order> Orders = new List<Order>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id:{0}   К-сть: {1}\t Назва книги: {2}\n\t    Замовлення:\n", Id, NumberOfBooks, Book.CommonName);
            foreach (Order e in Orders)
                sb.AppendFormat("\t\tДата видачі: {0}   Дата здачі: {1}   Бібліотекар: {2} {3}   Читач: {4} {5}\n"
                    , e.DateOfIssue.ToShortDateString(),e.DateOfAdmission.ToShortDateString(),e.Librarian.Person.FirstName,e.Librarian.Person.LastName,e.Reader.Person.FirstName,e.Reader.Person.LastName);
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }
}
