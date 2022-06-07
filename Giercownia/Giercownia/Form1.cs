using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giercownia
{
    public partial class Form1 : Form
    {
        int i = 0;
        bool tura = true;
        int countO = 0, countX=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (tura == true) btn.Text = "X";
                else btn.Text = "O";
                tura = !tura;
                i++;
                btn.Enabled = false;
                spr();
            }
            catch { };
        }
        public void spr()
        {
            bool win = false;
            //lewo prawo
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && button1.Text != "") win = true;
            else if ((button6.Text == button5.Text) && (button5.Text == button4.Text) && button6.Text != "") win = true;
            else if ((button9.Text == button8.Text) && (button8.Text == button7.Text) && button9.Text != "") win = true;

            //gora dol
            else if ((button1.Text == button6.Text) && (button6.Text == button9.Text) && button6.Text != "") win = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && button5.Text != "") win = true;
            else if ((button3.Text == button4.Text) && (button4.Text == button7.Text) && button4.Text != "") win = true;

            //skos
            else if ((button1.Text == button5.Text) && (button5.Text == button7.Text) && button1.Text != "") win = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button9.Text) && button5.Text != "") win = true;

            if (win == true)
            {
                string znak = "";
                if (tura)
                { znak = "O"; label3.Text = "O : " + ++countO; }
                else { znak = "X"; label2.Text = "X : " + ++countX; }
                MessageBox.Show("Wygrał: " + znak);
                Restart();
            }
            else if (i == 9){ MessageBox.Show("Remis"); Restart(); }

        }
        public void Restart()
        {
            foreach (Control btn in Controls.OfType<Button>())
            {
                btn.Enabled = true;
                btn.Text = "";
            }
            i = 0;
            tura = true;
            button10.Text = "Restart";
            button11.Text = "Resetuj wynik";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "O : 0";
            label2.Text = "X : 0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control btn in Controls.OfType<Button>())
            {
                btn.Enabled = true;
                btn.Text = "";
            }
            i = 0;
            tura = true;
            button10.Text = "Restart";
            button11.Text = "Resetuj wynik";
        }
    }
}

