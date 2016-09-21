using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Data;
using System.Xml.Schema;
using System.Windows.Forms;
using BookLending.Repository;


namespace BookLendingWF
{
    public partial class RepositoryController
    {
        private EntityRepository repository;
        //private DataSet ds;

        public string RepositoryObjectsAsString
        {
            get
            {
                repository.Load(dataSet);
                return repository.ToString(); }
        }

        private string fileName = "";
        public string FileName
        {
            get { return fileName; }
        }

        

        BindingNavigator bindingNavigator;
        Form form;
        BindingSource bindingSource = new BindingSource(); 
        DataGridView dataGridView;
        ListBox lstTable;

        public bool areChanges = false;

        public RepositoryController(string repositoryDirectory, 
            Form form,
            DataGridView dataGridView,             
            BindingNavigator bindingNavigator,             
            ListBox lstTable)
        {
            #region Перевірка на null
            if (repositoryDirectory == null)
            {
                throw new ArgumentNullException("repositoryDirectory");
            }
            if (form == null)
            {
                throw new ArgumentNullException("form");
            }
            if (dataGridView == null)
            {
                throw new ArgumentNullException("dataGridView");
            }
            if (bindingNavigator == null)
            {
                throw new ArgumentNullException("bindingNavigator");
            }
            if (lstTable == null)
            {
                throw new ArgumentNullException("lstTable");
            }
            #endregion
            repository = new BookRepository(repositoryDirectory);
            this.form = form;
            this.dataGridView = dataGridView;
            this.bindingNavigator = bindingNavigator;
            this.lstTable = lstTable;
            SetControlsEventHandlers();
        }

        

        private void ShowFileName()
        {
            if (String.IsNullOrEmpty(fileName))
            {
                form.Text = "BookRepository";
            }
            else
            {
                form.Text = "BookRepository - " + fileName;
            }
        }

        
        public void SaveFile()
        {
            if (dataGridView.DataSource != null) {

                
                UpdateRecords();
                dataSet.WriteXml(fileName);
                areChanges = false;

            }
        }

        public void PromptToSaveFile()
        {
            if (areChanges)
            {
                if (MessageBox.Show(form, "Зберегти зміни?",
                    "Збереження файлу", MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK)
                    SaveFile();
            }
            areChanges = false;
        }

        public void CreateFile()
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створити файл";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "xml файли (*.xml)|*.xml";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                try
                {
                    dataSet = repository.CreateDataSet();                    
                    SaveXmlSchema(Path.GetDirectoryName(fileName) + "\\Books.xsd");
                    dataSet.WriteXml(fileName);
                    //dataSet.WriteXml(fileName, XmlWriteMode.WriteSchema);
                    ShowDataSetMembers();
                    bindingSource.DataSource = dataSet;
                    ShowFileName();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void SaveXmlSchema()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Зберегти схему XML";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "Файли схеми xml(*.xsd)|*.xsd";
            dialog.RestoreDirectory = true;
            dialog.FileName = "Books";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataSet ds = repository.CreateDataSet();
                    ds.WriteXmlSchema(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void SaveXmlSchema(string pathToXsd)
        {
            if (!File.Exists(pathToXsd))
            {
                DataSet ds = repository.CreateDataSet();
                ds.WriteXmlSchema(pathToXsd);
            }
        }

        public void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Відкрити файл";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "xml файли (*.xml)|*.xml";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = dialog.FileName;
                    SaveXmlSchema(Path.GetDirectoryName(fileName) + "\\Books.xsd");
                    ValidateXML(dialog.FileName, repository.Directory + "\\Books.xsd");
                    PromptToSaveFile();
                    dataSet = repository.CreateDataSet();
                    repository.Load(fileName,dataSet);

                    //dataSet.ReadXml(fileName, XmlReadMode.IgnoreSchema);
                    ShowDataSetMembers();
                    bindingSource.DataSource = dataSet;
                    ShowFileName();
                }
                catch (XmlSchemaValidationException ex)
                {
                    MessageBox.Show("Помилка перевірки достовірності: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void SaveFileAs()
        {
            if (dataGridView.DataSource == null)
                return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Зберегти файл як";
            dialog.InitialDirectory = repository.Directory;
            dialog.Filter = "xml файли (*.xml)|*.xml";
            dialog.RestoreDirectory = true;
            dialog.FileName = Path.GetFileName(fileName);
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = dialog.FileName;
                SaveFile();
            }            
        }

        public void CloseFile()
        {
            if (lstTable.Items.Count == 0)
                return;
            //if (dataGridView.DataSource == null)
            //    return;            
            PromptToSaveFile();
            bindingSource.DataMember = "";
            lstTable.Items.Clear();
            bindingSource.DataSource = null;
            dataSet.Dispose();
            fileName = "";
            ShowFileName();
        }

        public void DeleteTimingTables()
        {
            if (dataSet != null)
            {
                if (dataSet.Tables["Librarian"].Columns.Contains("FullLibrarianName"))
                    dataSet.Tables["Librarian"].Columns.Remove("FullLibrarianName");
                if (dataSet.Tables["BookList"].Columns.Contains("Book+Blist"))
                    dataSet.Tables["BookList"].Columns.Remove("Book+Blist");
                if (dataSet.Tables["Reader"].Columns.Contains("FullName"))
                    dataSet.Tables["Reader"].Columns.Remove("FullName");
                if (dataSet.Tables["Person"].Columns.Contains("FullName"))
                    dataSet.Tables["Person"].Columns.Remove("FullName");
            }
        }
    }
}
