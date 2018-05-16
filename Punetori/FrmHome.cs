using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punetori
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            Punetori pun = new Punetori();

        }


        private void regjistroPunetoretToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegjstroPunetor().ShowDialog();

        }

        

        private void rrethNeshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAboutUs().Show();
        }

        private void regjistroPagatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegjistroPagen().ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmPunetorimepaga().ShowDialog();
        }

      


        private void shfaqPunetoretToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            txtShow.Visible = true;
            btnMbyllshfaqjen.Visible = true;
            txtShow.Text = "NrPersonal \t\tEmri \t\t Mbiemri \t\t Paga e fundit\n";
            txtShow.Text += "\r\n___________________________________________________________________\n";
            txtShow.Text += "\n" + Punetori.ListaPunetoreve() + "\n";
        }

        private void btnMbyllshfaqjen_Click_1(object sender, EventArgs e)
        {
            txtShow.Visible = false;
            btnMbyllshfaqjen.Visible = false;
        }

        private void aToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new frmPunetorimepaga().ShowDialog();
        }

       

        

          
    }
}
