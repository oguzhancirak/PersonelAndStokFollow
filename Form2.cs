using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HüsoPersonelTakipSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.ShowDialog();
        }

        private void btnPersonelList_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            form4.ShowDialog();

        }
        private void btnComputerList_Click(object sender, EventArgs e)
        {
            Form form6 = new Form6();
            form6.ShowDialog();
        }
        private void btnComputerAdd_Click(object sender, EventArgs e)
        {
            Form form7 = new Form7();
            form7.ShowDialog();

        }

       
    }
}
