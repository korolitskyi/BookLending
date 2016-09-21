using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyFormsLibrary.DataTablesForm
{
    public partial class BaseTableForm : Form
    {
        public delegate void VoidMethod();

        public event EventHandler<EventArgs> RecordsUpdater;

        public void OnRecordUpdater(EventArgs e)
        {
            if (RecordsUpdater != null) RecordsUpdater(this, e);
        }

        private VoidMethod saveDataMethod;

        protected DataSet dataSet;

        protected string tableName;

        protected BindingSource bindingSource = new BindingSource();

        protected virtual void VerifyDataSet()
        {
            if (!dataSet.Tables.Contains(tableName))
            {
                throw new Exception("dataSet не містить таблиці " + tableName);
            }
        }

        protected virtual void SetDataBinding()
        {

        }

        private void UpdateRecords()
        {
            this.Validate();
            bindingSource.EndEdit();
            OnRecordUpdater(new EventArgs());
        }

        public BaseTableForm()
        {
            InitializeComponent();
        }

        public BaseTableForm(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
        {
            #region Перевірка аргументів на null;
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentNullException("tableName");
            }
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (saveDataMethod == null)
            {
                throw new ArgumentNullException("saveDataMethod");
            }
            #endregion

            this.tableName = tableName;
            this.dataSet = dataSet;
            this.saveDataMethod = saveDataMethod;

            VerifyDataSet();
            InitializeComponent();

            this.Text = "Таблиця " + tableName;

            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = tableName;
            bindingNavigator1.BindingSource = bindingSource;

            SetDataBinding();
        }

        private void toolStripButtonUpdateRecords_Click(object sender, EventArgs e)
        {
            UpdateRecords();
        }

        private void toolStripButtonUndoRecord_Click(object sender, EventArgs e)
        {
            bindingSource.CancelEdit();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            saveDataMethod();
        }
    }
}
