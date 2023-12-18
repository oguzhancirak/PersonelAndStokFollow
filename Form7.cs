using HüsoPersonelTakipSistemi.Business;
using HüsoPersonelTakipSistemi.Entities;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        ComputerManager computerManager = new ComputerManager();
        List<Personel> computersss;
        private void Form7_Load(object sender, EventArgs e)
        {
                
                computersss = computerManager.GetAllHasComputers();
                cbxPcPersonel.DataSource= computersss;
                cbxPcPersonel.DisplayMember = "FirstName";
                cbxPcPersonel.ValueMember = "Id";

        }

        int id;
        private void cbxPcPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cbxPcPersonel.ValueMember != " ")
                    id = (int)cbxPcPersonel.SelectedValue;
            }
            catch (Exception)
            {

               
            }
            
        }

        private void btnPcAdd_Click(object sender, EventArgs e)
        {
            Computer computer1 = new Computer();
            computer1.PersonelId = id;
            computer1.ComputerBrand=txtPcBrand.Text;
            computer1.ComputerDescription=rctPcDescription.Text;

            computerManager.AddPc(computer1);
            PersonelManager manager = new PersonelManager();

            Personel p = manager.GetAll().Where(p1=>p1.Id==id).First();
            p.HasComputer = "evet";
           
            manager.UpdatedPersonel(p);
            this.Form7_Load(sender, e);




        }

       
    }
}
