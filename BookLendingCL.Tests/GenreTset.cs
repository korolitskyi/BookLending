using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookLending.Classes;

namespace BookLending.Tests
{
    [TestClass]
    public class GenreTset
    {
        [TestMethod]
        public void GenreTest_Create()
        {
            string name = "Detective";
            Genre genre = new Genre(name);
            Assert.AreEqual(genre.CommonName, name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenreTest_NameIsNull()
        {
            Genre genre = new Genre(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GenreTest_NameIsWhiteSpace()
        {
            Genre genre = new Genre(" ");
        }
    }
}
