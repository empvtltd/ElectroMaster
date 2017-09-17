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
    public partial class MainGUI : MetroFramework.Forms.MetroForm
    {
        public MainGUI()
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
            var myForm = new addemp.AddEmpInterface();
            myForm.Show();
        }

        private void sTARTNEWTRIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sTARTNEWSALESPOINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dISCOUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mANAGECUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEMOVECHANGEEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new deleteUpdateEmp.deleteUpadateEmployee();
            myForm.Show();
        }

        private void vIEWEMPLOYEEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new searchEmp.searchEmployee();
            myForm.Show();
        }

       

        private void sALARYDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new ViewSalary.ViewSalary();
            myForm.Show();
        }

        private void aDDATTENDANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void eMPLOYEEOFFDAYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tileManageBranch_Click(object sender, EventArgs e)
        {
            var myForm = new ElectroMaster.manageBranch();
            myForm.Show();
        }

        private void tile_Click(object sender, EventArgs e)
        {
            var myForm = new ElectroMaster.manageSalaryAdvance();
            myForm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            var myForm = new ElectroMaster.manageBranch();
            myForm.Show();
        }

        private void aDDATTENDANCEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var myForm = new addAttendance.addAttendanceEmployee();
            myForm.Show();
        }

        private void aDDEMPLOYEEOFFDAYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new OffDays.empOffDays();
            myForm.Show();
        }

        private void vIEWSALARYDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aDDSALARYDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var myForm = new OffDays.empOffDays();
            myForm.Show();*/
        }
    }
    }

