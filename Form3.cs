using HüsoPersonelTakipSistemi.Business;
using HüsoPersonelTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HüsoPersonelTakipSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonelManager personelManager = new PersonelManager();

            Personel personel1 = new Personel();
          
            personel1.Username=txtUserName.Text;
            personel1.Password=txtPassword.Text;
            personel1.Firstname=txtFirstName.Text;
            personel1.Surname = txtSurname.Text;
            personel1.Age=txtAge.Text;
            personel1.HasComputer = cbxHasComputer.Text.ToLower();
            personel1.WorkingUnit=txtWorkingUnit.Text;
            personel1.Phone=txtPhone.Text;
            personel1.Address=txtAddress.Text;
          
                personelManager.Add(personel1);
          
            
           
        }
        

        
    }
}
