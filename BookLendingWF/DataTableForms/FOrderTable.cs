using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FOrderTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        protected override void SetDataBinding()
        {
            base.SetDataBinding();

            InitializeComponent();

            txtNumberOfOrder.DataBindings.Add(new Binding("Text", bindingSource, "NumberOfOrder", true));
            

            cboLibrarian.DataSource = dataSet.Tables["Librarian"];//
            //dataSet.Tables["Person"].Columns.Add("FullName", typeof(string), "FirstName+' '+LastName");
            dataSet.Tables["Librarian"].Columns.Add("FullLibrarianName", typeof(string), "Parent(Person_Librarian).FirstName+' '+Parent(Person_Librarian).LastName+'   |   '+Ocupation");
            cboLibrarian.ValueMember = "Id";
            cboLibrarian.DisplayMember = "FullLibrarianName";
            cboLibrarian.DataBindings.Add("SelectedValue", bindingSource, "LibrarianId", true, DataSourceUpdateMode.OnPropertyChanged);

            cboBook.DataSource = dataSet.Tables["BookList"];
            dataSet.Tables["BookList"].Columns.Add("Book+Blist", typeof(string), "Parent(Book_BookList).CommonName+'   |   '+NumberOfBooks+' шт.'  ");
            cboBook.ValueMember = "Id";
            cboBook.DisplayMember = "Book+Blist";
            cboBook.DataBindings.Add("SelectedValue", bindingSource, "BookListId", true, DataSourceUpdateMode.OnPropertyChanged);
            
            
            cboReader.DataSource = dataSet.Tables["Reader"];
            dataSet.Tables["Reader"].Columns.Add("FullName", typeof(string), "Parent(Person_Reader).FirstName+' '+Parent(Person_Reader).LastName+'   |   №'+NumberTicket");
            cboReader.ValueMember = "Id";
            cboReader.DisplayMember = "FullName";
            cboReader.DataBindings.Add("SelectedValue", bindingSource, "ReaderId", true, DataSourceUpdateMode.OnPropertyChanged);

            txtDateOfIssue.DataBindings.Add(new Binding("Text",
                bindingSource, "DateOfIssue", true));

            txtDateOfAdmission.DataBindings.Add(new Binding("Text",
                bindingSource, "DateOfAdmission", true));
        }

        public FOrderTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) { 
                    
        }

        private void FOrderTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataSet.Tables["Librarian"].Columns.Contains("FullLibrarianName"))
                dataSet.Tables["Librarian"].Columns.Remove("FullLibrarianName");
            if (dataSet.Tables["BookList"].Columns.Contains("Book+Blist"))
                dataSet.Tables["BookList"].Columns.Remove("Book+Blist");
            if (dataSet.Tables["Reader"].Columns.Contains("FullName"))
                dataSet.Tables["Reader"].Columns.Remove("FullName");
            //dataSet.Tables["Person"].Columns.Remove("FullName");
        }

        private void chkDateOfIssue_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateOfIssue.Visible = chkDateOfIssue.Checked;
        }

        private void chkDateOfAdmission_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerDateOfAdmission.Visible = chkDateOfAdmission.Checked;
        }

        private void dateTimePickerDateOfIssue_ValueChanged(object sender, EventArgs e)
        {
            txtDateOfIssue.Text = dateTimePickerDateOfIssue.Value.ToShortDateString();
        }

        private void dateTimePickerDateOfAdmission_ValueChanged(object sender, EventArgs e)
        {
            txtDateOfAdmission.Text = dateTimePickerDateOfAdmission.Value.ToShortDateString();
        }

        

        
    }
}
