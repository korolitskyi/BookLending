using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FBookTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        protected override void SetDataBinding()
        {
            base.SetDataBinding();

            InitializeComponent(); 
            cboGenre.DataSource = (bindingSource.DataSource as DataSet).Tables["Genre"];
            cboGenre.ValueMember = "Id";
            cboGenre.DisplayMember = "CommonName";
            cboGenre.DataBindings.Add("SelectedValue", bindingSource, "GenreId", true, DataSourceUpdateMode.OnPropertyChanged);

            //cboEdition.DataSource = (bindingSource.DataSource as DataSet).Tables["Edition"];
            //cboEdition.ValueMember = "Id";
            //cboEdition.DisplayMember = "Name";
            //cboEdition.DataBindings.Add("SelectedValue", bindingSource, "EditionId", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public FBookTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod)
        {

        }

        private void FBookTable_Load(object sender, EventArgs e)
        {

        }
    }
}
