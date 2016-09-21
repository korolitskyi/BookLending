using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLending.Classes
{
    public class Book : DescribedIdentifiedNamedEntity
    {
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        internal List<Edition> Editions = new List<Edition>();

        internal List<FuncPerson> FuncPersons = new List<FuncPerson>();

        public Book(string name,Genre genre)
            : base(name)
        {
            if (genre == null)
                throw new ArgumentNullException("Book.Book", "genre");
            this.Genre = genre;
            this.GenreId = genre.Id;
            genre.Books.Add(this);
        }

        public Book() { }

        public override string ToString()
        {
            LineIndent.Current.Increase();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id:{0}  Назва: {1}\n"
                + "{2}Жанр: {3}\n", Id, CommonName, LineIndent.Current.Value, Genre.CommonName);
            if (Editions.Count != 0)
            {
                sb.AppendFormat("{0}Видавництва:\n",LineIndent.Current.Value);
            }
            LineIndent.Current.Increase();
            foreach (Edition e in Editions)
                sb.AppendFormat("{0}{1}\n",LineIndent.Current.Value, e.CommonName);   
            LineIndent.Current.Decrease(); 
            if (FuncPersons.Count != 0)
            {
                sb.AppendFormat("{0}Функції персон:\n",LineIndent.Current.Value);
            }
            LineIndent.Current.Increase();
            foreach (FuncPerson e in FuncPersons)
                sb.AppendFormat("{0}Функція: {1}   Ім'я {2}a: {3} {4}\n"
                    , LineIndent.Current.Value, e.Function.CommonName, e.Function.CommonName.ToLower(), e.Person.FirstName, e.Person.LastName);  
            LineIndent.Current.Decrease();
            sb.AppendFormat("\n");           
            LineIndent.Current.Decrease();
            return sb.ToString();
        }
    }
}
