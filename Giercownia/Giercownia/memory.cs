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
    public partial class Form2 : Form
    {
        int czas = 15;
        PictureBox pierwszy;
        Timer sec = new Timer { Interval = 1000 };
        Timer KlikCec = new Timer();
        Random rand = new Random();
        bool klik = false;
        

        public Form2()
        {
            InitializeComponent();
        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> img
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.p1,
                    Properties.Resources.p2,
                    Properties.Resources.p3,
                    Properties.Resources.p4,
                    Properties.Resources.p5,
                    Properties.Resources.p6,
                    Properties.Resources.p7,
                    Properties.Resources.p8,
                };
            }
        }

        

        private void Ukryj()
        {
            foreach (var im in pictureBoxes)
            {
                im.Image = Properties.Resources.zakryte;
            }

        }
        private PictureBox Slot()
        {
            int num;
            do
            {
                num = rand.Next(0, pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null); return pictureBoxes[num];
        }

        private void startCzas()
        {
            sec.Start();
            sec.Tick += delegate
            {
                czas--;
                if (czas < 0)
                {

                    sec.Stop();
                    MessageBox.Show("Koniec czasu");
                    this.Close();

                }
                var time = TimeSpan.FromSeconds(czas);
                label1.Text = "00:" + time.ToString();
            };
        }

        private void Losowe()
        {
            foreach (var im in img)
            {
                Slot().Tag = im;
                Slot().Tag = im;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!klik) return;
            var img = (PictureBox)sender;
            if(pierwszy == null)
            {
                pierwszy = img;
                img.Image = (Image)img.Tag;
                return;
            }

            img.Image = (Image)img.Tag;

            if(img.Image == pierwszy.Image && img != pierwszy)
            {
                img.Visible = pierwszy.Visible = false;
                {
                    pierwszy = img;
                }
                Ukryj();
            }
            else
            {
                klik = false;
                KlikCec.Start();
            }
            pierwszy = null;
            if (pictureBoxes.Any(x => x.Visible)) return;
            MessageBox.Show("Wygrałeś, BRAWO!!!");
            button1.Enabled = true;
            this.Close();
            
        }
        private void Klik_Tick(object sender, EventArgs e)
        {
            Ukryj();
            klik = true;
            KlikCec.Stop();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            klik = true;
            Losowe();
            Ukryj();
            startCzas();
            KlikCec.Interval = 1000;
            KlikCec.Tick += Klik_Tick;
            button1.Enabled = false;
            
        }
    }

}
