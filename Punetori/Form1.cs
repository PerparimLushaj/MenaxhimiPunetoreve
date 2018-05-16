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
    public partial class FrmRegjstroPunetor : Form
    {
        Punetori objPunetori = new Punetori();

        public FrmRegjstroPunetor()
        {

            InitializeComponent();
        }
      
	


        private void btnRegjistroPunetorin_Click(object sender, EventArgs e)
        {
            Pozita _pozita = new Pozita();
            if (cmbPozita.SelectedIndex == 0)
            { _pozita = Pozita.Punetor; }
            else if (cmbPozita.SelectedIndex == 1)
            { _pozita = Pozita.Shef; }
            else if (cmbPozita.SelectedIndex == 2)
            { _pozita = Pozita.Pastrues; }
            else if (cmbPozita.SelectedIndex == 3)
            { _pozita = Pozita.Menaxher; }


            int a;
            try 
            {
                a = int.Parse(txtNrPersonal.Text);
                if (txtNrPersonal.Text != String.Empty && TxtEmri.Text != String.Empty && txtMbiemri.Text != String.Empty &&txtKompania.Text!=String.Empty
                    //if (txtNrPersonal.Text != String.Empty && TxtEmri.Text != String.Empty && txtMbiemri.Text != String.Empty
                   //&& System.Text.RegularExpressions.Regex.IsMatch(TxtEmri.Text, "^[a-zA-Z]+$") && System.Text.RegularExpressions.Regex.IsMatch(txtMbiemri.Text, "^[a-zA-Z]+$"))
                    )
                {
                    Punetori.RegjistroPunetorin(txtNrPersonal.Text, TxtEmri.Text, txtMbiemri.Text, dtpdatelindja.Value, txtKompania.Text, _pozita);
                    MessageBox.Show("Punëtori u regjistrua me sukses.");
                    
                }
                else
                {
                    MessageBox.Show("Te gjitha fushat duhet te plotesohen","Informim !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                txtNrPersonal.Clear();
                TxtEmri.Clear();
                txtMbiemri.Clear();
                txtKompania.Clear();
                dtpdatelindja.Value = DateTime.Now;
            }
            catch
            {

                MessageBox.Show("Punëtori nuk u regjistrua !\n Numri personal duhet të jetë vlerë.", "Informim !",
                   MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtNrPersonal.Focus();
                txtNrPersonal.Clear();
                TxtEmri.Clear();
                txtMbiemri.Clear();
                txtKompania.Clear();
                dtpdatelindja.Value = DateTime.Now;
            }



        }
        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialog1 = new OpenFileDialog();
            opendialog1.ShowDialog();
            opendialog1.Filter = "(*.jpg)|*";
            if (opendialog1.ShowDialog() == DialogResult.OK)
            {
                //PictureBox PictureBox1 = new PictureBox();                    
                pbPuntori.Image = new Bitmap(opendialog1.FileName);
            }
            opendialog1.Dispose();

        }

        private void FrmRegjstroPunetor_Load(object sender, EventArgs e)
        {
            cmbPozita.SelectedIndex = 0;
        }

        private void btnDalja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
