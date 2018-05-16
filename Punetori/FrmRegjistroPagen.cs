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
    public partial class FrmRegjistroPagen : Form
    {
        public FrmRegjistroPagen()
        {
            InitializeComponent();
        }
        Punetori objPunetori = new Punetori();
        Punetori_Detajet pun = new Punetori_Detajet();



        private void btnRegjistroPagen_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtViti.Text) < 2017 && decimal.Parse(txtPaga.Text) > 0 && int.Parse(txtmuaji.Text) < 13))
            {
                string numriPersonal = gridPunetoret.SelectedRows[0].Cells["NumriPersonal"].Value.ToString();
                Punetori_Detajet puntori_i_selektuar = Punetori.punetoret.Where(p => p.NumriPersonal == numriPersonal).FirstOrDefault();
                Punetori.RegjistroPagen(puntori_i_selektuar, int.Parse(txtmuaji.Text), int.Parse(txtViti.Text), decimal.Parse(txtPaga.Text));
                MessageBox.Show("Paga e punëtorit u regjistrua");
                txtViti.Clear();
                txtPaga.Clear();
                txtmuaji.Clear();
            }
            else
            {
                MessageBox.Show("Paga e punetorit nuk u regjistrua.Kontrolloni te dhenat per Vite,Page dhe Muaj !");
                txtPaga.Focus();
                txtPaga.Clear();
                txtViti.Clear();
                txtmuaji.Clear();

            }

        }

        private void FrmRegjistroPagen_Load(object sender, EventArgs e)
        {
            gridPunetoret.DataSource = Punetori.punetoret;
        }

      
    }
}
