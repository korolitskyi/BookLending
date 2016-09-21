using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Person : IdentifiedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<FuncPerson> FuncPersons = new List<FuncPerson>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\tІм'я: {1}\t  Прізвище: {2}\n", Id, FirstName, LastName);
            if (FuncPersons.Count != 0)
            {
                sb.AppendFormat("\t   Книги:\n");
            }
            foreach (FuncPerson e in FuncPersons)

                sb.AppendFormat("\t\t{0}   Функція: {1}\n"
                    , e.Book.CommonName, e.Function.CommonName);

            sb.AppendFormat("\n");
            return sb.ToString();
        }

    }
}
