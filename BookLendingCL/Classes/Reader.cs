using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Reader:Person
    {
        public int NumberTicket { get; set; }
        public int PersonId { get; set; }

        internal Person Person { get; set; }

        internal List<Order> Orders = new List<Order>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Номер читача: {0}\t Читач: {1} {2}\n\t    Замовлення:\n",NumberTicket,Person.FirstName,Person.LastName);
            foreach (Order e in Orders)
                sb.AppendFormat("\t\tКнига: {0}   Бібліотекар: {1} {2}   Дата видачі: {3}   Дата здачі: {4}\n"
                    , e.BookList.Book.CommonName, e.Librarian.Person.FirstName, e.Librarian.Person.LastName, e.DateOfIssue.ToShortDateString(), e.DateOfAdmission.ToShortDateString());
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }
}
