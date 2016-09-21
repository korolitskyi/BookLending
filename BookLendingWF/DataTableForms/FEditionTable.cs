using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FEditionTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        protected override void SetDataBinding() {

            base.SetDataBinding();

            InitializeComponent();
        }

        public FEditionTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) {
        }
    }
}
