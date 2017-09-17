using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addemp
{
    public partial class AddEmpInterface : MetroFramework.Forms.MetroForm
    {
        public AddEmpInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            validations.validations v = new validations.validations();
            if (v.isEmpty(txtPhone.Text))
            {
                ErrMiddleName.Text = "Enter the middle name";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                //DateTime time = DateTime.Now;
                string date = dtStartDate.Value.ToString();

                Employee.Employee aa = new Employee.Employee();
                aa.setFName(txtFirstName.Text);
                aa.setMName(txtMiddleName.Text);
                aa.setLName(txtLastName.Text);
                aa.setNic(txtNic.Text);
                aa.setNumber(txtPhone.Text);
                aa.setAddress(txtAddress.Text);
                aa.setStartDate(dtStartDate.Value.Date);
                //aa.setStartDate(DateTime.ParseExact(date, "yyyy-mm-dd", System.Globalization.CultureInfo.InvariantCulture));
                int itemSelected = cmbBranch.SelectedIndex;
                switch(itemSelected)
                {
                    case 1:aa.setBranch("Badulla");break;
                    case 2:aa.setBranch("Colombo");break;
                }
                if (rdioAdmin.Checked)
                {
                    aa.setDesignation(1);
                }
                else if (rdioSales.Checked )
                {
                    aa.setDesignation(2);
                }
                else if (rdioCollector.Checked)
                {
                    aa.setDesignation(3);
                }              
                                
                bool t = aa.addEmployee();
                if (t == true)
                {
                    MessageBox.Show("Saved!!");
                }
                else
                {
                    MessageBox.Show("Not Saved!!");
                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text= " ";
            txtLastName.Text = " ";
            txtMiddleName.Text = " ";
            txtNic.Text = " ";
            txtPhone.Text = " ";
            txtAddress.Text = " ";
            cmbBranch.Text = " ";
            dtStartDate.Text = " ";
            rdioAdmin.Checked = false;
            rdioSales.Checked = false;
            rdioCollector.Checked  = false;

        }

        private void txtMiddleName_Click(object sender, EventArgs e)
        {
            validations.validations v = new validations.validations();
            if (v.isEmpty(txtFirstName.Text) )
            {
                ErrFirstName.Text = "Enter the first name";
            }
        }

        private void ErrMiddleName_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            validations.validations v = new validations.validations();
            if (v.isEmpty(txtMiddleName.Text))
            {
                ErrMiddleName.Text = "Enter the middle name";
            }
        }

        private void txtNic_Click(object sender, EventArgs e)
        {
            validations.validations v = new validations.validations();

            if (v.isEmpty(txtLastName.Text))             
            {
                ErrLastName.Text = "Enter the last name";
            }
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            validations.validations v = new validations.validations();

            if (v.isEmpty(txtNic.Text))            
            {
                ErrNic.Text = "Enter the NIC number";
            }
        }

        private void gdPhoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ErrDesignation_Click(object sender, EventArgs e)
        {

        }
    }
}
