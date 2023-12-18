using HüsoPersonelTakipSistemi.Business;
using HüsoPersonelTakipSistemi.DataAccess;
using HüsoPersonelTakipSistemi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HüsoPersonelTakipSistemi
{
    public partial class Form4 : Form
    {
        PersonelManager manager = new PersonelManager();
        
        public delegate void ReturnIdCallBack(int id);

        public ReturnIdCallBack ReturnId;

        public Form4()
        {
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            dgwGetAll.DataSource = manager.GetAll();
            btnShowPc.Visible = false;
        }



        private void txtFindPerson_TextChanged(object sender, EventArgs e)
        {
          
            dgwGetAll.DataSource = manager.GetAll().Where(p=>p.Username.Contains(txtFindPerson.Text)).ToList();
        }

        private void cbxIsComputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dgwGetAll.DataSource = manager.GetHasComputer(cbxIsComputer);
        }

        int i;
        string y;
        object z;

        private void dgwGetAll_Click(object sender, EventArgs e)
        {

            try
            {
                z= dgwGetAll.CurrentRow.Cells[0].Value;
                y = dgwGetAll.CurrentRow.Cells[7].Value.ToString().Trim();
                if (z is int zz)
                {
                    i = zz;
                   
                }
                if (y == "evet")
                {
                    Button btnView=new Button();
                    btnView.Text = "BİLGİSAYAR";
                    btnView.ForeColor = Color.Green;
                    btnShowPc.Visible = true;
                    dgwGetAll.CurrentRow.Cells[7].Value = btnView.Text;
                    

                }
                else if (y == "BİLGİSAYAR")
                {
                    btnShowPc.Visible = true;
                }
                else
                {
                    btnShowPc.Visible = false;
                }
            }
            catch (Exception)
            {

            }
        }
       
       
        private void btnShowPc_Click(object sender, EventArgs e)
        {
            
            Form5 form5 = new Form5();
            this.ReturnId += new ReturnIdCallBack(form5.ReturnId);
            ReturnId((int)dgwGetAll.CurrentRow.Cells[0].Value);
            form5.ShowDialog();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            manager.DeletePersonel(manager.Get(i));

        }

        private void btnUptade_Click(object sender, EventArgs e)
        {
            try
            {
                Personel person = manager.Get(i);

                

                if (person != null)
                {
                    for (int j = 0; j < dgwGetAll.Columns.Count; j++)
                    {
                        if (person.Id == (int)dgwGetAll.CurrentRow.Cells[0].Value)
                        {
                            switch (dgwGetAll.Columns[j].Name.ToString())
                            {
                                case "Username":
                                    person.Username = dgwGetAll.CurrentRow.Cells[1].Value.ToString();
                                    break;
                                case "Firstname":
                                    person.Firstname = dgwGetAll.CurrentRow.Cells[3].Value.ToString();
                                    break;
                                case "Surname":
                                    person.Surname = dgwGetAll.CurrentRow.Cells[4].Value.ToString();
                                    break;
                                case "Age":
                                    person.Age = dgwGetAll.CurrentRow.Cells[5].Value.ToString();
                                    break;
                                case "WorkingUnit":
                                    person.WorkingUnit = dgwGetAll.CurrentRow.Cells[6].Value.ToString();
                                    break;
                                case "Phone":
                                    person.Phone = dgwGetAll.CurrentRow.Cells[8].Value.ToString();
                                    break;
                                case "Address":
                                    person.Address = dgwGetAll.CurrentRow.Cells[9].Value.ToString();
                                    break;
         
                            }
                         
                        }
                    }
                    manager.UpdatedPersonel(person);

                }
            }
            catch (Exception)
            {

                
            }
          
        }

       
        
    }
}
