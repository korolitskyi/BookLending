using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Windows.Forms;

namespace BookLendingWF
{
    public partial class RepositoryController
    {

        private DataSet dataSet;
        public DataSet DataSet
        {
            get { return dataSet; }
        }

        

        private string xmlSchemaFileName = "";
        public string XmlSchemaFileName
        {
            get { return xmlSchemaFileName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(
                        "XmlSchemaFileName");
                }
                if (Path.GetExtension(value) != ".xsd")
                {
                    throw new Exception(
                        "Розширення файлу XML-схеми "
                        + " не .xsd");
                }
                xmlSchemaFileName = value;
            }
        }

        private void ShowDataSetMembers()
        {
            lstTable.Items.Clear();
            foreach (DataTable dt in dataSet.Tables)
            {
                lstTable.Items.Add(dt.TableName);
            }
        }

        public void UpdateRecords()
        {
            if (String.IsNullOrEmpty(fileName))
                return;
            form.Validate();
            bindingSource.EndEdit();            
        }

        public void UndoRecord()
        {
            bindingSource.CancelEdit();
        }

        private void ValidateXML(string xmlFileName, string xsdFileName)
        {
            XDocument xDocument = XDocument.Load(xmlFileName);
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("", xsdFileName);
            xDocument.Validate(schemaSet, null);
        }

        public void ChangeTable()
        {
            string tableName = "";
            if (lstTable.SelectedIndex >= 0)
            {
                tableName = lstTable.SelectedItem.ToString();
            }
            bindingSource.DataMember = tableName;
            dataGridView.DataSource = null; //вирішення проблеми з перестановкою колонок
            dataGridView.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;
        }

        private void SetControlsEventHandlers()
        {
            dataGridView.CellClick += new DataGridViewCellEventHandler(dataGridView_CellClick);
            dataGridView.CellValueChanged += new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.BeginEdit(true);
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            areChanges = true;
        }
    }
}
