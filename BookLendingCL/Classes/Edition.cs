using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Edition : DescribedIdentifiedNamedEntity
    {
        internal List<Book> Books = new List<Book>();
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\t Назва: {1}\n\t     Книги:\n",Id,CommonName);
            foreach (Book e in Books)
                sb.AppendFormat("\t\tId: {0}     Назва: {1}\n",e.Id, e.CommonName);
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }        
}
