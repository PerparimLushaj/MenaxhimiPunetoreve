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
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }



        private void listStudentev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStudentev.SelectedIndex == 0)
            {
                loadListBox();
            }
            if (listStudentev.SelectedIndex == 1)
            {
                loadListBox1();
            }
            
           
        }
        

        private void loadListBox1()
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Emri: Përparim");
            listBox1.Items.Add("Mbiemri: Lushaj");
            listBox1.Items.Add("Email: perparimlushaj@gmail.com");
            listBox1.Items.Add("Id: 154183");
        }
     

        

      
        private void loadListBox()
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Emri: Filan  ");
            listBox1.Items.Add("Mbiemri: Fisteku");
            listBox1.Items.Add("Email: filanfisteku@gmail.com");
            listBox1.Items.Add("Id: filani");
        }

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {
            loadListBox();
        }
    }
}
