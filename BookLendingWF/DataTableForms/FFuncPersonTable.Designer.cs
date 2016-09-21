namespace BookLendingWF.DataTableForms
{
    partial class FFuncPersonTable
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FunctionId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.FunctionId,
            this.PersonId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // BookId
            // 
            this.BookId.HeaderText = "Книга";
            this.BookId.Name = "BookId";
            this.BookId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FunctionId
            // 
            this.FunctionId.HeaderText = "Функція";
            this.FunctionId.Name = "FunctionId";
            this.FunctionId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PersonId
            // 
            this.PersonId.HeaderText = "Персона";
            this.PersonId.Name = "PersonId";
            this.PersonId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FFuncPersonTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FFuncPersonTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFuncPersonTable_FormClosing);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn BookId;
        private System.Windows.Forms.DataGridViewComboBoxColumn FunctionId;
        private System.Windows.Forms.DataGridViewComboBoxColumn PersonId;
    }
}
