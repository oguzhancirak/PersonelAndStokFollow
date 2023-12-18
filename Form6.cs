﻿using HüsoPersonelTakipSistemi.Business;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ComputerManager manager = new ComputerManager();
            dgwGetComputers.DataSource = manager.GetAllPC().ToList();
        }
    }
}
