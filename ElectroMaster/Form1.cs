using System;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aDDEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new AddEmployee();
            myForm.Show();
        }

        private void sTARTNEWTRIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new NewTrip();
            myForm.Show();
        }

        private void sTARTNEWSALESPOINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new SalesPointLogin();
            myForm.Show();
        }

        private void dISCOUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new ManageDiscount();
            myForm.Show();
        }

        private void mANAGECUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new ManageCustomers();
            myForm.Show();
        }
    }
}
