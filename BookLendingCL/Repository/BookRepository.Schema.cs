using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookLending.Classes;

namespace BookLending.Repository
{
    public partial class BookRepository
    {
        public override DataSet CreateDataSet()
        {
            DataSet ds = new DataSet("BookLending");
            ds.Tables.Add(CreateBookTable());
            ds.Tables.Add(CreateEditionBooksTable());
            ds.Tables.Add(CreatePersonTable());
            ds.Tables.Add(CreateBookListTable());
            ds.Tables.Add(CreateEditionTable());
            ds.Tables.Add(CreateFuncPersonTable());
            ds.Tables.Add(CreateFunctionTable());
            ds.Tables.Add(CreateGenreTable());
            ds.Tables.Add(CreateLibrarianTable());
            ds.Tables.Add(CreateOrderTable());
            ds.Tables.Add(CreateReaderTable());

            CreateRelations(ds);

            return ds;
        }

        public DataTable CreateBookTable()
        {
            DataTable dt = new DataTable("Book");

            AddIdColumn(dt);
            AddNameColumns(dt);

            DataColumn dc;
            dc = new DataColumn("GenreId", typeof(int));
            dt.Columns.Add(dc);

            AddDescribColumns(dt);
            AddNoteColumns(dt);

            return dt;
        }

        public DataTable CreateEditionBooksTable()
        {
            DataTable dt = new DataTable("EditionBooks");

            DataColumn dc;

            dc = new DataColumn("EditionId", typeof(int));
            dt.Columns.Add(dc);
            dc = new DataColumn("BookId", typeof(int));
            dt.Columns.Add(dc);

            return dt;
        }

        public DataTable CreatePersonTable()
        {
            DataTable dt = new DataTable("Person");

            AddIdColumn(dt);
            DataColumn dc;

            dc = new DataColumn("FirstName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("LastName", typeof(string));
            dt.Columns.Add(dc);
            AddNoteColumns(dt);

            return dt;
        }

        public DataTable CreateBookListTable()
        {
            DataTable dt = new DataTable("BookList");           

            AddIdColumn(dt);
            DataColumn dc;

            dc = new DataColumn("BookId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("NumberOfBooks", typeof(int));
            dc.DefaultValue = 1;
            dt.Columns.Add(dc);

            AddNoteColumns(dt);
            return dt;
        }

        public DataTable CreateEditionTable()
        {
            DataTable dt = new DataTable("Edition");
            AddIdColumn(dt);
            AddNameColumns(dt);
            AddDescribColumns(dt);
            AddNoteColumns(dt);
            return dt;
        }

        public DataTable CreateFuncPersonTable()
        {
            DataTable dt = new DataTable("FuncPerson");

            DataColumn dc;

            dc = new DataColumn("BookId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("PersonId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("FunctionId", typeof(int));
            dt.Columns.Add(dc);


            return dt;
        }

        public DataTable CreateFunctionTable()
        {
            DataTable dt = new DataTable("Function");

            AddIdColumn(dt);
            AddNameColumns(dt);
            AddDescriptionColumns(dt);
            AddNoteColumns(dt);

            return dt;
        }

        public DataTable CreateGenreTable()
        {
            DataTable dt = new DataTable("Genre");
            AddIdColumn(dt);
            AddNameColumns(dt);
            AddDescribColumns(dt);
            AddNoteColumns(dt);
            return dt;
        }

        public DataTable CreateLibrarianTable()
        {
            DataTable dt = new DataTable("Librarian");
            AddIdColumn(dt);

            DataColumn dc;

            dc = new DataColumn("PersonId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Ocupation", typeof(string));
            dt.Columns.Add(dc);

            AddNoteColumns(dt);

            return dt;
        }

        public DataTable CreateOrderTable()
        {
            DataTable dt = new DataTable("Order");

            DataColumn dc;

            dc = new DataColumn("NumberOfOrder", typeof(int));
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dt.Columns.Add(dc);

            dc = new DataColumn("LibrarianId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("BooklistId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("ReaderId", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("DateOfIssue", typeof(DateTime));
            dt.Columns.Add(dc);

            dc = new DataColumn("DateOfAdmission", typeof(DateTime));
            dt.Columns.Add(dc);

            AddNoteColumns(dt);
            return dt;
        }

        public DataTable CreateReaderTable()
        {
            DataTable dt = new DataTable("Reader");
            AddIdColumn(dt);

            DataColumn dc;

            dc = new DataColumn("NumberTicket", typeof(int));
            dc.AutoIncrement = true;
            dc.AutoIncrementSeed = 1;
            dt.Columns.Add(dc);

            dc = new DataColumn("PersonId", typeof(int));
            dt.Columns.Add(dc);

            AddNoteColumns(dt);

            return dt;
        }

        private void CreateRelations(DataSet ds)
        {
            DataRelation drl;
            drl = new DataRelation("Book_Genre",
                ds.Tables["Genre"].Columns["Id"],
                ds.Tables["Book"].Columns["GenreId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Book_BookList",
                ds.Tables["Book"].Columns["Id"],
                ds.Tables["BookList"].Columns["BookId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Book_FuncPerson",
                ds.Tables["Book"].Columns["Id"],
                ds.Tables["FuncPerson"].Columns["BookId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("EditionBooks_Book",
                ds.Tables["Book"].Columns["Id"],
                ds.Tables["EditionBooks"].Columns["BookId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("EditionBooks_Edition",
                ds.Tables["Edition"].Columns["Id"],
                ds.Tables["EditionBooks"].Columns["EditionId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Function_FuncPerson",
                ds.Tables["Function"].Columns["Id"],
                ds.Tables["FuncPerson"].Columns["FunctionId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Person_FuncPerson",
                ds.Tables["Person"].Columns["Id"],
                ds.Tables["FuncPerson"].Columns["PersonId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Person_Librarian",
                ds.Tables["Person"].Columns["Id"],
                ds.Tables["Librarian"].Columns["PersonId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Person_Reader",
                ds.Tables["Person"].Columns["Id"],
                ds.Tables["Reader"].Columns["PersonId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("BookList_Order",
                ds.Tables["BookList"].Columns["Id"],
                ds.Tables["Order"].Columns["BookListId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Order_Librarian",
                ds.Tables["Librarian"].Columns["Id"],
                ds.Tables["Order"].Columns["LibrarianId"]);
            ds.Relations.Add(drl);

            drl = new DataRelation("Order_Reader",
                ds.Tables["Reader"].Columns["Id"],
                ds.Tables["Order"].Columns["ReaderId"]);
            ds.Relations.Add(drl);
        }
    }
}
