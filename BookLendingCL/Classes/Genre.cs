using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Genre : DescribedIdentifiedNamedEntity
    {
        public List<Book> Books = new List<Book>();

        public Genre(string name)
            : base(name){ }

        public Genre() { }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\tЖанр: {1}\n\t    Книги:\n",Id,CommonName);
            foreach (Book e in Books)
                sb.AppendFormat("\t\t{0}\n", e.CommonName);
            sb.AppendFormat("\n");
            return sb.ToString();
        }
    }
}
