using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudyFormsLibrary.DataTablesForm
{
    public partial class EntityTableForm : StudyFormsLibrary.DataTablesForm.BaseTableForm
    {
        protected bool BindColumn(string columnName, Control control, TableLayoutPanel tblPanel, int index)
        {
            if (dataSet.Tables[tableName].Columns.Contains(columnName))
            {
                control.DataBindings.Add(new Binding("Text",
                    bindingSource, columnName, true));
                return true;
            }
            else
            {
                tblPanel.RowStyles[index].SizeType =
                SizeType.Absolute;
                tblPanel.RowStyles[index].Height = 0;
                return false;
            }
        }

        protected override void SetDataBinding()
        {

            InitializeComponent();

            lblId.Text = "";
            BindColumn("Id", lblId, tableLayoutPanelTop, 1);
            BindColumn("CommonName", txtCommonName, tableLayoutPanelTop, 2);

            BindColumn("Note", txtNote, tableLayoutPanelBottom, 0);

            if (!BindColumn("Site", txtSite, tableLayoutPanelBottom, 1))
            {
                txtSite.Visible = false;
            }
            
            if (!BindColumn("Description", txtDescription, tableLayoutPanelBottom, 2))
            {
                pnlDescription.Visible = false;
            }
        }

        internal EntityTableForm()
        {
            InitializeComponent();
        }

        public EntityTableForm(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod)
        {
        }

        

        

        
    }
}
