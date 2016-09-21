using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookLending.Classes;

namespace BookLending
{
    partial class Program
    {
        //static Book[] bookArray =
        //{
        //    new Book("GarryPotter"),
        //    new Book("Sherlock"),
        //    new Book("Titans")
        //};


        static void StudyObject()
        {
            //studylibrary();
            //studylibraryenum();
        }


        //static void studylibrary()
        //{
        //    Librarian lbr1 = new Librarian("fname", "lname");
        //    Console.WriteLine("{0}", lbr1.Name);

        //    Edition ed1 = new Edition("Ababagalamaga");
        //    Console.WriteLine("{0}", ed1.Name);

        //    Order od1 = new Order(new DateTime(1996, 4, 25));
        //    Console.WriteLine("Dato of issue: {0}", od1.Dateofissue.ToLongDateString());
        //    Console.WriteLine("Date of admission: {0}", od1.Dateofadmission.ToLongDateString());

        //    Reader rd1 = new Reader("Maks", "Korolytsky",1);
        //    Console.WriteLine("{0}", rd1.Name);

        //    FuncPerson fp1 = new FuncPerson("Librerian", 1);
        //    Genre g1 = new Genre("Fentesi");
        //}


        public static string ToString<T>(IEnumerable<T> objectEnum, string prompt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}:\n", prompt);
            foreach (T e in objectEnum)
            {
                sb.AppendFormat("\t {0} \n", e.ToString());
            }
            return sb.ToString();
        }

        //static void studylibraryenum()
        //{
        //    Console.WriteLine(
        //        "!==== StudyBookEnum START");
        //    Console.WriteLine("\nbookArray:");
        //    foreach (Book e in bookArray)
        //    {
        //        Console.WriteLine("\t" + e.ToString());
        //    }
        //    Console.WriteLine(ToString(bookArray, "bookArray"));
        //}
    }
}
