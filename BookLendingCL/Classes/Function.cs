using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLending.Classes
{
    public class Function : IdentifiedNamedEntity
    {
        internal List<FuncPerson> FuncPersons = new List<FuncPerson>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\t Функція: {1}\n", Id, CommonName);
            if (FuncPersons.Count != 0)
            {
                sb.AppendFormat("\t   Книги:\n");
            }
            foreach (FuncPerson e in FuncPersons)
                sb.AppendFormat("\t\t{0}   Ім'я {1}a: {2} {3}\n"
                    , e.Book.CommonName, e.Function.CommonName.ToLower(), e.Person.FirstName, e.Person.LastName);
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }
}
