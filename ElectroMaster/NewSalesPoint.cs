﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroMaster
{
    public partial class NewSalesPoint : MetroFramework.Forms.MetroForm
    {
        public NewSalesPoint()
        {
            InitializeComponent();
        }

        private void NewSalesPoint_Load(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var myForm = new NewSalesPointView();
            myForm.Show();
            this.Dispose();
        }
    }
}
