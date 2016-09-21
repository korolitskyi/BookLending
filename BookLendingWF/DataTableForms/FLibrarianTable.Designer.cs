namespace BookLendingWF.DataTableForms
{
    partial class FLibrarianTable
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
            this.lblLibrarianCaption = new System.Windows.Forms.Label();
            this.cboLibrarian = new System.Windows.Forms.ComboBox();
            this.lblOcupationCaption = new System.Windows.Forms.Label();
            this.txtOcupation = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblLibrarianCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboLibrarian, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOcupationCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOcupation, 1, 1);
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
            // lblLibrarianCaption
            // 
            this.lblLibrarianCaption.AutoSize = true;
            this.lblLibrarianCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLibrarianCaption.Location = new System.Drawing.Point(12, 2);
            this.lblLibrarianCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblLibrarianCaption.Name = "lblLibrarianCaption";
            this.lblLibrarianCaption.Size = new System.Drawing.Size(65, 13);
            this.lblLibrarianCaption.TabIndex = 3;
            this.lblLibrarianCaption.Text = "Бібліотекар";
            // 
            // cboLibrarian
            // 
            this.cboLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLibrarian.FormattingEnabled = true;
            this.cboLibrarian.Location = new System.Drawing.Point(162, 2);
            this.cboLibrarian.Margin = new System.Windows.Forms.Padding(2);
            this.cboLibrarian.Name = "cboLibrarian";
            this.cboLibrarian.Size = new System.Drawing.Size(510, 21);
            this.cboLibrarian.TabIndex = 5;
            // 
            // lblOcupationCaption
            // 
            this.lblOcupationCaption.AutoSize = true;
            this.lblOcupationCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOcupationCaption.Location = new System.Drawing.Point(12, 27);
            this.lblOcupationCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblOcupationCaption.Name = "lblOcupationCaption";
            this.lblOcupationCaption.Size = new System.Drawing.Size(45, 13);
            this.lblOcupationCaption.TabIndex = 3;
            this.lblOcupationCaption.Text = "Посада";
            // 
            // txtOcupation
            // 
            this.txtOcupation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOcupation.Location = new System.Drawing.Point(162, 27);
            this.txtOcupation.Margin = new System.Windows.Forms.Padding(2);
            this.txtOcupation.Name = "txtOcupation";
            this.txtOcupation.Size = new System.Drawing.Size(510, 20);
            this.txtOcupation.TabIndex = 6;
            // 
            // FLibrarianTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Name = "FLibrarianTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLibrarianTable_FormClosing);
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
        private System.Windows.Forms.Label lblLibrarianCaption;
        private System.Windows.Forms.ComboBox cboLibrarian;
        private System.Windows.Forms.Label lblOcupationCaption;
        private System.Windows.Forms.TextBox txtOcupation;
    }
}
