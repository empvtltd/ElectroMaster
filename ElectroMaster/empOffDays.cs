using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffDays
{
    public partial class empOffDays : MetroFramework.Forms.MetroForm
    {
        public empOffDays()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Text = " ";
            txtEmpName.Text = " ";
            txtReason.Text = " ";
            cmbType.SelectedIndex = 0;
            dtEndDateAndTime.Value = DateTime.Now;
            dtStartDateAndTime.Value = DateTime.Now;


           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
