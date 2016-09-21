using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data;
using BookLending.Classes;

namespace BookLending.Repository
{
    public partial class EntityRepository
    {
        

        public void AddIdColumn(DataTable dt, string columnIDName = "Id", bool autoIncrement = true)
        {
            DataColumn dc = new DataColumn(columnIDName, typeof(int));
            dc.AutoIncrement = autoIncrement;
            dc.AutoIncrementSeed = 1;
            dc.AllowDBNull = false;
            dc.Unique = true;
            dt.Columns.Add(dc);

            dt.PrimaryKey = new DataColumn[] {
                dt.Columns[columnIDName] 
            };
        }

        public void AddNameColumns(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("CommonName", typeof(string));
            dc.AllowDBNull = false;
            dt.Columns.Add(dc);
        }

        public void AddDescribColumns(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("Description", typeof(string));
            dt.Columns.Add(dc);
            dc = new DataColumn("Site", typeof(string));
            dt.Columns.Add(dc);
        }

        public void AddDescriptionColumns(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("Description", typeof(string));
            dt.Columns.Add(dc);
        }

        public void AddNoteColumns(DataTable dt)
        {
            DataColumn dc;
            dc = new DataColumn("Note", typeof(string));
            dt.Columns.Add(dc);
        }
    }
}
