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

namespace Giercownia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Teściowej")
            {
                TextReader reader = new StreamReader("zart/tesciowa.txt");
                richTextBox1.Text = reader.ReadToEnd();
            }
            else if (comboBox1.Text == "Blondynkach")
            {
                TextReader reader = new StreamReader("zart/blondynkach.txt");
                richTextBox1.Text = reader.ReadToEnd();
            }
            if (comboBox1.Text == "Jasiu")
            {
                TextReader reader = new StreamReader("zart/jasiu.txt");
                richTextBox1.Text = reader.ReadToEnd();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.speechControl1.textToSpeech = this.richTextBox1.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void wiecej_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.google.pl/search?q=kawaly+o+"+comboBox1.Text);
        }
    }
    
}
