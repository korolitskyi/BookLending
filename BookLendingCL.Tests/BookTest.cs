using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookLending.Classes;

namespace BookLendingCL.Tests
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void BookTest_Create()
        {
            Genre genre = new Genre("Detective");
            Book book = new Book("Sherlok",genre);
            CollectionAssert.Contains(genre.Books, book);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BookTest_GenreIsNull()
        {
            Book book = new Book("Sherlok", null);
        }
    }
}
