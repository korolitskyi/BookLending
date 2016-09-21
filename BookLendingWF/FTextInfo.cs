using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookLendingWF
{
    public partial class FTextInfo : Form
    {
        public string Title
        {
            set { this.Text = value; }
        }

        public string DataString
        {
            get { return richTextBox1.Text; }
            set { richTextBox1.Text = value; }
        }

        public string FileName
        {
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    this.Text = "Файл: (не задано)";
                    richTextBox1.Text = "";
                }
                else
                {
                    this.Text = "Файл: " + value;
                    StreamReader SR = new StreamReader(value, Encoding.UTF8);
                    richTextBox1.Text = SR.ReadToEnd();
                    //richTextBox1.LoadFile(value, RichTextBoxStreamType.PlainText);
                }
            }
        }

        public FTextInfo()
        {
            InitializeComponent();
        }

        private void FTextInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
