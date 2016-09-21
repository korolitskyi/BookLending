using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookLendingWF.DataTableForms
{
    public partial class FReaderTable : StudyFormsLibrary.DataTablesForm.EntityTableForm
    {
        
        //public FReaderTable()
        //{
        //    InitializeComponent();
        //}
        

        protected override void SetDataBinding()
        {
            base.SetDataBinding();

            InitializeComponent();

            ////string connectionString = "Data Source = GW;Initial Catalog=VSQL;Integrated Security=True";
            ////string CommandText = "SELECTED * FROM Person";
            ////SqlConnection conn = new SqlConnection(connectionString);
            ////conn.Open();
            ////SqlCommand myCommand = conn.CreateCommand();
            ////myCommand.CommandText = CommandText;
            ////SqlDataAdapter dataAdapter = new SqlDataAdapter();
            ////dataAdapter.SelectCommand = myCommand;
            ////DataSet ds = new DataSet();
            //dataAdapter.Fill(ds, "Person");
            //conn.Close();
            
            
            
            txtNumberTicket.DataBindings.Add(new Binding("Text", bindingSource, "NumberTicket", true));
            
            //cboReader.DataSource=(bindingSource.DataSource as DataSet).Tables["Person"];

            cboReader.DataSource = dataSet.Tables["Person"];
            cboReader.ValueMember="Id";
            dataSet.Tables["Person"].Columns.Add("FullName", typeof(string), "FirstName+' '+LastName");
            cboReader.DisplayMember = "FullName";  
            cboReader.DataBindings.Add("SelectedValue", bindingSource, "PersonId", true, DataSourceUpdateMode.OnPropertyChanged);
            
        }

        public FReaderTable(string tableName, DataSet dataSet, VoidMethod saveDataMethod)
            : base(tableName, dataSet, saveDataMethod) { 
                    
        }

        private void FReaderTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dataSet.Tables["Person"].Columns.Contains("FullName"))
                dataSet.Tables["Person"].Columns.Remove("FullName");
        }
    }
}
