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
    public partial class Giercowniaa : Form
    {
        private int childFormNumber = 0;

        public Giercowniaa()
        {
            InitializeComponent();
        }

        private void kółkoIKrzyżykToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 kolko = new Form1();
            kolko.MdiParent = this;
            kolko.Text = "Kółko i krzyżyk gra ";
            kolko.Show();
        }

        private void memoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 memory = new Form2();
            memory.MdiParent = this;
            memory.Text = "Memory gra ";
            memory.Show();
        }

        private void oknaToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "1":  //only in the second level
                    LayoutMdi(MdiLayout.Cascade); break;
                case "Cascade":  //option text
                    LayoutMdi(MdiLayout.Cascade); break;
                case "Vertical":
                    LayoutMdi(MdiLayout.TileVertical); break;
                case "Horizontal":
                    LayoutMdi(MdiLayout.TileHorizontal); break;
                case "Close All":
                    foreach (Form childForm in MdiChildren)
                    {
                        childForm.Close();
                    }
                    break;
            }
        }

        private void żartowniśToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 opowiadacz = new Form3();
            opowiadacz.MdiParent = this;
            opowiadacz.Text = "Opowiadacz numer ";
            opowiadacz.Show();
        }
    }
}
