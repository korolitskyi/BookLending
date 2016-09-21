using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BookLending.Repository;
using BookLending.Classes;


namespace BookLending
{
    public partial class Program
    {
        static void StudyRepository()
        {
            StudyRepositoryIO();
        }

        static void StudyRepositoryIO()
        {
            Console.WriteLine("!----StudyRepositoryIO----");
            EntityRepository repository =
                new BookRepository();

            try
            {
                repository.Save("Book.xsd");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
