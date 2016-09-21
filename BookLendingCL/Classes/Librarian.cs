using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Librarian : Person
    {
        public int PersonId { get; set; }
        public string Ocupation { get; set; }

        internal Person Person { get; set; }

        internal List<Order> Orders = new List<Order>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}    Персона: {1} {2}\tПосада: {3}\n\t    Замовлення:\n", Person.Id, Person.FirstName, Person.LastName, Ocupation);
            foreach (Order e in Orders)
                sb.AppendFormat("\t\tКнига: {0}   Читач: {1} {2}   Дата видачі: {3}   Дата здачі: {4}\n"
                    , e.BookList.Book.CommonName, e.Reader.Person.FirstName, e.Reader.Person.LastName, e.DateOfIssue.ToShortDateString(), e.DateOfAdmission.ToShortDateString());
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }
}
