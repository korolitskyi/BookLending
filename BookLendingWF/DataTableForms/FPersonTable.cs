using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FPersonTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        protected override void SetDataBinding() {

            base.SetDataBinding();


            InitializeComponent();
            txtFirstName.DataBindings.Add(new Binding("Text", bindingSource, "FirstName", true));
            txtLastName.DataBindings.Add(new Binding("Text", bindingSource, "LastName", true));
        }

        public FPersonTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) {
        }
    }
}
