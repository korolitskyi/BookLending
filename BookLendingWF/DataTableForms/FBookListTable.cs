using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FBookListTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        protected override void SetDataBinding()
        {
            base.SetDataBinding();

            InitializeComponent();

            txtNumberOfBooks.DataBindings.Add(new Binding("Text", bindingSource, "NumberOfBooks", true));

            cboBook.DataSource = (bindingSource.DataSource as DataSet).Tables["Book"];
            cboBook.ValueMember = "Id";
            cboBook.DisplayMember = "CommonName";
            cboBook.DataBindings.Add("SelectedValue", bindingSource, "BookId", true, DataSourceUpdateMode.OnPropertyChanged);

        }

        public FBookListTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod)
        {

        }
    }
}
