using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FLibrarianTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        
        protected override void SetDataBinding()
        {
            base.SetDataBinding();

            InitializeComponent();
            txtOcupation.DataBindings.Add(new Binding("Text", bindingSource, "Ocupation", true));


            
            dataSet.Tables["Person"].Columns.Add("FullName", typeof(string), "FirstName+' '+LastName");
            
            cboLibrarian.DataSource = dataSet.Tables["Person"];
            
            cboLibrarian.ValueMember = "Id";
            cboLibrarian.DisplayMember = "FullName";
            cboLibrarian.DataBindings.Add("SelectedValue", bindingSource, "PersonId", true, DataSourceUpdateMode.OnPropertyChanged);

        
        }

        public FLibrarianTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) { 
                    
        }



        private void FLibrarianTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataSet.Tables["Person"].Columns.Contains("FullName"))
                dataSet.Tables["Person"].Columns.Remove("FullName");
        }
    }
}
