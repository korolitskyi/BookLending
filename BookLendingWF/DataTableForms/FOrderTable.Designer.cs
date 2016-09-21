namespace BookLendingWF.DataTableForms
{
    partial class FOrderTable
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
            this.lblDateofadmission = new System.Windows.Forms.Label();
            this.cboReader = new System.Windows.Forms.ComboBox();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.cboLibrarian = new System.Windows.Forms.ComboBox();
            this.lblDateofissue = new System.Windows.Forms.Label();
            this.lblReaderTable = new System.Windows.Forms.Label();
            this.lblBookTable = new System.Windows.Forms.Label();
            this.lblLibrarianTable = new System.Windows.Forms.Label();
            this.lblNumberOfOrderCaption = new System.Windows.Forms.Label();
            this.txtNumberOfOrder = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDateOfIssue = new System.Windows.Forms.TextBox();
            this.chkDateOfIssue = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDateOfAdmission = new System.Windows.Forms.TextBox();
            this.chkDateOfAdmission = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateOfAdmission = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Size = new System.Drawing.Size(684, 147);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateofadmission, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cboReader, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboBook, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboLibrarian, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDateofissue, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReaderTable, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblBookTable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLibrarianTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNumberOfOrderCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumberOfOrder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(684, 147);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDateofadmission
            // 
            this.lblDateofadmission.AutoSize = true;
            this.lblDateofadmission.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateofadmission.Location = new System.Drawing.Point(12, 125);
            this.lblDateofadmission.Margin = new System.Windows.Forms.Padding(2);
            this.lblDateofadmission.Name = "lblDateofadmission";
            this.lblDateofadmission.Size = new System.Drawing.Size(61, 13);
            this.lblDateofadmission.TabIndex = 5;
            this.lblDateofadmission.Text = "Дата здачі";
            // 
            // cboReader
            // 
            this.cboReader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReader.FormattingEnabled = true;
            this.cboReader.Location = new System.Drawing.Point(162, 76);
            this.cboReader.Margin = new System.Windows.Forms.Padding(2);
            this.cboReader.Name = "cboReader";
            this.cboReader.Size = new System.Drawing.Size(510, 21);
            this.cboReader.TabIndex = 6;
            // 
            // cboBook
            // 
            this.cboBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(162, 51);
            this.cboBook.Margin = new System.Windows.Forms.Padding(2);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(510, 21);
            this.cboBook.TabIndex = 6;
            // 
            // cboLibrarian
            // 
            this.cboLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLibrarian.FormattingEnabled = true;
            this.cboLibrarian.Location = new System.Drawing.Point(162, 26);
            this.cboLibrarian.Margin = new System.Windows.Forms.Padding(2);
            this.cboLibrarian.Name = "cboLibrarian";
            this.cboLibrarian.Size = new System.Drawing.Size(510, 21);
            this.cboLibrarian.TabIndex = 6;
            // 
            // lblDateofissue
            // 
            this.lblDateofissue.AutoSize = true;
            this.lblDateofissue.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateofissue.Location = new System.Drawing.Point(12, 101);
            this.lblDateofissue.Margin = new System.Windows.Forms.Padding(2);
            this.lblDateofissue.Name = "lblDateofissue";
            this.lblDateofissue.Size = new System.Drawing.Size(67, 13);
            this.lblDateofissue.TabIndex = 4;
            this.lblDateofissue.Text = "Дата видачі";
            // 
            // lblReaderTable
            // 
            this.lblReaderTable.AutoSize = true;
            this.lblReaderTable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblReaderTable.Location = new System.Drawing.Point(12, 76);
            this.lblReaderTable.Margin = new System.Windows.Forms.Padding(2);
            this.lblReaderTable.Name = "lblReaderTable";
            this.lblReaderTable.Size = new System.Drawing.Size(37, 13);
            this.lblReaderTable.TabIndex = 3;
            this.lblReaderTable.Text = "Читач";
            // 
            // lblBookTable
            // 
            this.lblBookTable.AutoSize = true;
            this.lblBookTable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBookTable.Location = new System.Drawing.Point(12, 51);
            this.lblBookTable.Margin = new System.Windows.Forms.Padding(2);
            this.lblBookTable.Name = "lblBookTable";
            this.lblBookTable.Size = new System.Drawing.Size(37, 13);
            this.lblBookTable.TabIndex = 2;
            this.lblBookTable.Text = "Книга";
            // 
            // lblLibrarianTable
            // 
            this.lblLibrarianTable.AutoSize = true;
            this.lblLibrarianTable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLibrarianTable.Location = new System.Drawing.Point(12, 26);
            this.lblLibrarianTable.Margin = new System.Windows.Forms.Padding(2);
            this.lblLibrarianTable.Name = "lblLibrarianTable";
            this.lblLibrarianTable.Size = new System.Drawing.Size(65, 13);
            this.lblLibrarianTable.TabIndex = 1;
            this.lblLibrarianTable.Text = "Бібліотекар";
            // 
            // lblNumberOfOrderCaption
            // 
            this.lblNumberOfOrderCaption.AutoSize = true;
            this.lblNumberOfOrderCaption.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNumberOfOrderCaption.Location = new System.Drawing.Point(12, 2);
            this.lblNumberOfOrderCaption.Margin = new System.Windows.Forms.Padding(2);
            this.lblNumberOfOrderCaption.Name = "lblNumberOfOrderCaption";
            this.lblNumberOfOrderCaption.Size = new System.Drawing.Size(106, 13);
            this.lblNumberOfOrderCaption.TabIndex = 1;
            this.lblNumberOfOrderCaption.Text = "Номер замовлення";
            // 
            // txtNumberOfOrder
            // 
            this.txtNumberOfOrder.Location = new System.Drawing.Point(162, 2);
            this.txtNumberOfOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfOrder.Name = "txtNumberOfOrder";
            this.txtNumberOfOrder.Size = new System.Drawing.Size(117, 20);
            this.txtNumberOfOrder.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.txtDateOfIssue);
            this.flowLayoutPanel1.Controls.Add(this.chkDateOfIssue);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerDateOfIssue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 99);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 24);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // txtDateOfIssue
            // 
            this.txtDateOfIssue.Location = new System.Drawing.Point(2, 2);
            this.txtDateOfIssue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateOfIssue.Name = "txtDateOfIssue";
            this.txtDateOfIssue.Size = new System.Drawing.Size(117, 20);
            this.txtDateOfIssue.TabIndex = 8;
            // 
            // chkDateOfIssue
            // 
            this.chkDateOfIssue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDateOfIssue.AutoSize = true;
            this.chkDateOfIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkDateOfIssue.Location = new System.Drawing.Point(121, 0);
            this.chkDateOfIssue.Margin = new System.Windows.Forms.Padding(0);
            this.chkDateOfIssue.Name = "chkDateOfIssue";
            this.chkDateOfIssue.Size = new System.Drawing.Size(32, 23);
            this.chkDateOfIssue.TabIndex = 9;
            this.chkDateOfIssue.Text = ". . .";
            this.chkDateOfIssue.UseVisualStyleBackColor = true;
            this.chkDateOfIssue.CheckedChanged += new System.EventHandler(this.chkDateOfIssue_CheckedChanged);
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(154, 1);
            this.dateTimePickerDateOfIssue.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerDateOfIssue.TabIndex = 10;
            this.dateTimePickerDateOfIssue.Value = new System.DateTime(2014, 6, 24, 0, 0, 0, 0);
            this.dateTimePickerDateOfIssue.Visible = false;
            this.dateTimePickerDateOfIssue.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfIssue_ValueChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.txtDateOfAdmission);
            this.flowLayoutPanel2.Controls.Add(this.chkDateOfAdmission);
            this.flowLayoutPanel2.Controls.Add(this.dateTimePickerDateOfAdmission);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(160, 123);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(232, 24);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // txtDateOfAdmission
            // 
            this.txtDateOfAdmission.Location = new System.Drawing.Point(2, 2);
            this.txtDateOfAdmission.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateOfAdmission.Name = "txtDateOfAdmission";
            this.txtDateOfAdmission.Size = new System.Drawing.Size(117, 20);
            this.txtDateOfAdmission.TabIndex = 8;
            // 
            // chkDateOfAdmission
            // 
            this.chkDateOfAdmission.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDateOfAdmission.AutoSize = true;
            this.chkDateOfAdmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkDateOfAdmission.Location = new System.Drawing.Point(121, 0);
            this.chkDateOfAdmission.Margin = new System.Windows.Forms.Padding(0);
            this.chkDateOfAdmission.Name = "chkDateOfAdmission";
            this.chkDateOfAdmission.Size = new System.Drawing.Size(32, 23);
            this.chkDateOfAdmission.TabIndex = 9;
            this.chkDateOfAdmission.Text = ". . .";
            this.chkDateOfAdmission.UseVisualStyleBackColor = true;
            this.chkDateOfAdmission.CheckedChanged += new System.EventHandler(this.chkDateOfAdmission_CheckedChanged);
            // 
            // dateTimePickerDateOfAdmission
            // 
            this.dateTimePickerDateOfAdmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfAdmission.Location = new System.Drawing.Point(154, 1);
            this.dateTimePickerDateOfAdmission.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePickerDateOfAdmission.Name = "dateTimePickerDateOfAdmission";
            this.dateTimePickerDateOfAdmission.Size = new System.Drawing.Size(77, 20);
            this.dateTimePickerDateOfAdmission.TabIndex = 10;
            this.dateTimePickerDateOfAdmission.Value = new System.DateTime(2014, 6, 24, 0, 0, 0, 0);
            this.dateTimePickerDateOfAdmission.Visible = false;
            this.dateTimePickerDateOfAdmission.ValueChanged += new System.EventHandler(this.dateTimePickerDateOfAdmission_ValueChanged);
            // 
            // FOrderTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 455);
            this.Name = "FOrderTable";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FOrderTable_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLibrarianTable;
        private System.Windows.Forms.Label lblDateofadmission;
        private System.Windows.Forms.Label lblBookTable;
        private System.Windows.Forms.Label lblReaderTable;
        private System.Windows.Forms.Label lblDateofissue;
        private System.Windows.Forms.ComboBox cboLibrarian;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.ComboBox cboReader;
        private System.Windows.Forms.Label lblNumberOfOrderCaption;
        private System.Windows.Forms.TextBox txtNumberOfOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtDateOfIssue;
        private System.Windows.Forms.CheckBox chkDateOfIssue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtDateOfAdmission;
        private System.Windows.Forms.CheckBox chkDateOfAdmission;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfAdmission;

    }
}
