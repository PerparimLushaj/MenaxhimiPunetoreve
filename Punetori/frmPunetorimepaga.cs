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
    public partial class frmPunetorimepaga : Form
    {
        public frmPunetorimepaga()
        {
            InitializeComponent();
        }

        private void frmPunetorimepaga_Load(object sender, EventArgs e)
        {
            lblNrPunetoreve.Text = Punetori.NumriIpunetoreve().ToString();




            dataGridView1.DataSource = Punetori.punetoret;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            string kerko = txtKerko.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(kerko))
                    {
                        row.Selected = true;
                        break;
                    }
               
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Me emrin '" + kerko + "' nuk eshte gjetur asnje!.");
            }
          
            }
        }
    }

