using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FEditionBooksTable : StudyFormsLibrary.DataTablesForm.BaseTableForm
    {

        protected override void VerifyDataSet() {

            base.VerifyDataSet();

            if (!dataSet.Tables.Contains("Book"))
            {
                throw new Exception("dataSet не містить таблиці "
                    + "Book");
            }
            if (!dataSet.Tables.Contains("Edition"))
            {
                throw new Exception("dataSet не містить таблиці "
                    + "Edition");
            }
        }

        public FEditionBooksTable(string tableName,
            DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) {

        }

        protected override void SetDataBinding() {

            base.SetDataBinding(); // якщо override

            InitializeComponent(); // якщо override

            bindingSource.DataMember = "EditionBooks";
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

            comboBoxColumn = dataGridView1.Columns["EditionId"]
                 as DataGridViewComboBoxColumn;
            if (comboBoxColumn == null)
            {
                throw new Exception(
                    "Тип стовпця не DataGridViewComboBoxColumn");
            }

            comboBoxColumn.ValueMember = "Id";
            comboBoxColumn.DisplayMember = "CommonName";
            comboBoxColumn.DataSource = dataSet.Tables["Edition"];
            comboBoxColumn.DataPropertyName = "EditionId";
            comboBoxColumn.MaxDropDownItems = 40;

            //comboBoxColumn = dataGridView1.Columns["FunctionId"]
            //     as DataGridViewComboBoxColumn;
            //if (comboBoxColumn == null)
            //{
            //    throw new Exception(
            //        "Тип стовпця не DataGridViewComboBoxColumn");
            //}

            //comboBoxColumn.ValueMember = "Id";
            //comboBoxColumn.DisplayMember = "Name";
            //comboBoxColumn.DataSource =
            //    dataSet.Tables["Function"];
            //comboBoxColumn.DataPropertyName =
            //    "FunctionId";
            //comboBoxColumn.MaxDropDownItems = 40;
        }
    }
}
