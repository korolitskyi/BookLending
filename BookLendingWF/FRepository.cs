using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using StudyFormsLibrary.DataTablesForm;
using BookLendingWF.DataTableForms;

namespace BookLendingWF
{
    public partial class FRepository : Form
    {
        RepositoryController controller;

        private void SetControlState()
        {

        }

        public FRepository()
        {
            InitializeComponent();
            controller = new RepositoryController(@"..\..\..\..\BookRepository",this, dataGridView1,bindingNavigator1,lstTable);
            controller.XmlSchemaFileName = @"..\..\..\..\BookRepository\Books.xsd";
        }

        private void FRepository_Load(object sender, EventArgs e)
        {
            toolStripEnd.AutoSize = true;  //для того щоб панелька була з самого права 
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            controller.CreateFile();
            SetControlState();
        }

        private void lstTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.ChangeTable();
            SetControlState();
        }

        private void mnuFileSchema_Click(object sender, EventArgs e)
        {
            controller.SaveXmlSchema();
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            controller.OpenFile();
            SetControlState();
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            controller.SaveFile();
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            controller.SaveFileAs();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            controller.PromptToSaveFile();
            this.Close();
        }

        private void FRepository_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.DeleteTimingTables();
            controller.PromptToSaveFile();
        }

        private void mnuRecordsUndo_Click(object sender, EventArgs e)
        {
            controller.UndoRecord();
        }

        private void mnuRecordsUpdate_Click(object sender, EventArgs e)
        {
            controller.UpdateRecords();
        }

        private void mnuViewToolPanelsStandard_Click(object sender, EventArgs e)
        {
            int tSEtmp = toolStripEnd.Left;
            toolStripStandard.Visible = mnuViewToolPanelsStandard.Checked;
            toolStripEnd.Left = tSEtmp; // при зміні відображ стнд панелі енд панель не міняється
        }

        private void mnuToolStripMenuEnd_Click(object sender, EventArgs e)
        {
            toolStripEnd.Visible = mnuToolStripMenuEnd.Checked;
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            controller.PromptToSaveFile();
            controller.CloseFile();
        }

        private void btnTableForm_Click(object sender, EventArgs e)
        {
            if (lstTable.SelectedIndex < 0)
                return;

            controller.PromptToSaveFile();

            BaseTableForm frm = null;
            string tableName = lstTable.SelectedItem.ToString();

            if (tableName == "Book")
            {
                frm = new FBookTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Genre")
            {
                frm = new FGenreTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Edition")
            {
                frm = new FEditionTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Function")
            {
                frm = new FFunctionTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Person")
            {
                frm = new FPersonTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Reader")
            {
                frm = new FReaderTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Librarian")
            {
                frm = new FLibrarianTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "FuncPerson")
            {
                frm = new FFuncPersonTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "BookList")
            {
                frm = new FBookListTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "Order")
            {
                frm = new FOrderTable(tableName, controller.DataSet, controller.SaveFile);
            }
            else if (tableName == "EditionBooks")
            {
                frm = new FEditionBooksTable(tableName, controller.DataSet, controller.SaveFile);
            }

            if (frm != null)
                frm.ShowDialog();


            dataGridView1.Refresh();
        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            FTextInfo frm = new FTextInfo();
            frm.FileName = controller.XmlSchemaFileName;
            frm.ShowDialog();
        }

        private void bttnFile_Click(object sender, EventArgs e)
        {
            FTextInfo frm = new FTextInfo();
            frm.FileName = controller.FileName;
            frm.ShowDialog();
        }

        private void bttnDataObj_Click(object sender, EventArgs e)
        {
            FTextInfo frm = new FTextInfo();
            frm.Title = "Граф об'єктів сховища даних";
            frm.DataString = controller.RepositoryObjectsAsString;
            frm.ShowDialog();
        }

        

        
    }
}
