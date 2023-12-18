using HüsoPersonelTakipSistemi.Business;
using HüsoPersonelTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HüsoPersonelTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PersonelManager manager = new PersonelManager();

            manager.Get(txtUsername, txtPassword);
            this.Hide();
           
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
