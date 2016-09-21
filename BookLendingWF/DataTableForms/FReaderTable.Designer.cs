namespace BookLendingWF.DataTableForms
{
    partial class FReaderTable
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
            this.lblReaderCaption = new System.Windows.Forms.Label();
            this.lblNumberTicketCaption = new System.Windows.Forms.Label();
            this.cboReader = new System.Windows.Forms.ComboBox();
            this.txtNumberTicket = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblReaderCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumberTicketCaption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboReader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumberTicket, 1, 1);
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
            // lblReaderCaption
            // 
            this.lblReaderCaption.AutoSize = true;
            this.lblReaderCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReaderCaption.Location = new System.Drawing.Point(12, 2);
            this.lblReaderCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblReaderCaption.Name = "lblReaderCaption";
            this.lblReaderCaption.Size = new System.Drawing.Size(37, 13);
            this.lblReaderCaption.TabIndex = 2;
            this.lblReaderCaption.Text = "Читач";
            // 
            // lblNumberTicketCaption
            // 
            this.lblNumberTicketCaption.AutoSize = true;
            this.lblNumberTicketCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumberTicketCaption.Location = new System.Drawing.Point(12, 27);
            this.lblNumberTicketCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblNumberTicketCaption.Name = "lblNumberTicketCaption";
            this.lblNumberTicketCaption.Size = new System.Drawing.Size(79, 13);
            this.lblNumberTicketCaption.TabIndex = 1;
            this.lblNumberTicketCaption.Text = "Номер квитка";
            // 
            // cboReader
            // 
            this.cboReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReader.FormattingEnabled = true;
            this.cboReader.Location = new System.Drawing.Point(162, 2);
            this.cboReader.Margin = new System.Windows.Forms.Padding(2);
            this.cboReader.Name = "cboReader";
            this.cboReader.Size = new System.Drawing.Size(510, 21);
            this.cboReader.TabIndex = 4;
            // 
            // txtNumberTicket
            // 
            this.txtNumberTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberTicket.Location = new System.Drawing.Point(162, 27);
            this.txtNumberTicket.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberTicket.Name = "txtNumberTicket";
            this.txtNumberTicket.Size = new System.Drawing.Size(510, 20);
            this.txtNumberTicket.TabIndex = 3;
            // 
            // FReaderTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Name = "FReaderTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FReaderTable_FormClosing);
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
        private System.Windows.Forms.Label lblReaderCaption;
        private System.Windows.Forms.Label lblNumberTicketCaption;
        private System.Windows.Forms.TextBox txtNumberTicket;
        private System.Windows.Forms.ComboBox cboReader;

    }
}
