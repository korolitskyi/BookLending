using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FFuncPersonTable : StudyFormsLibrary.DataTablesForm.BaseTableForm
    {
        
        protected override void VerifyDataSet() {

            

            base.VerifyDataSet();

            if (!dataSet.Tables.Contains("Book"))
            {
                throw new Exception("dataSet не містить таблиці "
                    + "Book");
            }
            if (!dataSet.Tables.Contains("Person"))
            {
                throw new Exception("dataSet не містить таблиці "
                    + "Person");
            }
            if (!dataSet.Tables.Contains("Function"))
            {
                throw new Exception("dataSet не містить таблиці "
                    + "Function");
            }
        }

        public FFuncPersonTable(string tableName,
            DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) {

            //InitializeComponent(); //якщо SetDataBinding new

            //SetDataBinding(); //якщо new
        }

        //protected new void SetDataBinding() {
        protected override void SetDataBinding() {

            base.SetDataBinding(); // якщо override

            InitializeComponent(); // якщо override

            bindingSource.DataMember = "FuncPerson";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;

            DataGridViewComboBoxColumn comboBoxColumn =
                dataGridView1.Columns["BookId"]
                 as DataGridViewComboBoxColumn;
            if (comboBoxColumn == null)
            {
                throw new Exception(
                    "Тип стовпця не DataGridViewComboBoxColumn");
            }
            comboBoxColumn.ValueMember = "Id";
            comboBoxColumn.DisplayMember = "CommonName";
            comboBoxColumn.DataSource = dataSet.Tables["Book"];
            comboBoxColumn.DataPropertyName = "BookId";
            comboBoxColumn.MaxDropDownItems = 40;

            comboBoxColumn = dataGridView1.Columns["PersonId"]
                 as DataGridViewComboBoxColumn;
            if (comboBoxColumn == null)
            {
                throw new Exception(
                    "Тип стовпця не DataGridViewComboBoxColumn");
            }

           
            comboBoxColumn.DataSource = dataSet.Tables["Person"];
            comboBoxColumn.ValueMember = "Id";
            dataSet.Tables["Person"].Columns.Add("FullName", typeof(string), "FirstName+' '+LastName");
            comboBoxColumn.DisplayMember = "FullName";
            comboBoxColumn.DataPropertyName ="PersonId";
            comboBoxColumn.MaxDropDownItems = 40;

            comboBoxColumn = dataGridView1.Columns["FunctionId"]
                 as DataGridViewComboBoxColumn;
            if (comboBoxColumn == null)
            {
                throw new Exception(
                    "Тип стовпця не DataGridViewComboBoxColumn");
            }

            comboBoxColumn.ValueMember = "Id";
            comboBoxColumn.DisplayMember = "CommonName";
            comboBoxColumn.DataSource =
                dataSet.Tables["Function"];
            comboBoxColumn.DataPropertyName =
                "FunctionId";
            comboBoxColumn.MaxDropDownItems = 40;
        }

        private void FFuncPersonTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataSet.Tables["Person"].Columns.Contains("FullName"))
                dataSet.Tables["Person"].Columns.Remove("FullName");
        }
    }
}
