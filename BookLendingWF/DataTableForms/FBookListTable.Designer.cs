namespace BookLendingWF.DataTableForms
{
    partial class FBookListTable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenreCaption = new System.Windows.Forms.Label();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.txtNumberOfBooks = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Size = new System.Drawing.Size(684, 49);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGenreCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboBook, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumberOfBooks, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кількість";
            // 
            // lblGenreCaption
            // 
            this.lblGenreCaption.AutoSize = true;
            this.lblGenreCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGenreCaption.Location = new System.Drawing.Point(12, 2);
            this.lblGenreCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblGenreCaption.Name = "lblGenreCaption";
            this.lblGenreCaption.Size = new System.Drawing.Size(37, 13);
            this.lblGenreCaption.TabIndex = 2;
            this.lblGenreCaption.Text = "Книга";
            // 
            // cboBook
            // 
            this.cboBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(162, 2);
            this.cboBook.Margin = new System.Windows.Forms.Padding(2);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(510, 21);
            this.cboBook.TabIndex = 4;
            // 
            // txtNumberOfBooks
            // 
            this.txtNumberOfBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberOfBooks.Location = new System.Drawing.Point(162, 27);
            this.txtNumberOfBooks.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfBooks.Name = "txtNumberOfBooks";
            this.txtNumberOfBooks.Size = new System.Drawing.Size(510, 20);
            this.txtNumberOfBooks.TabIndex = 5;
            // 
            // FBookListTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Name = "FBookListTable";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenreCaption;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.TextBox txtNumberOfBooks;
    }
}
