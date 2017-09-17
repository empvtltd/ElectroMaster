using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deleteUpdateEmp
{
    public partial class deleteUpadateEmployee : MetroFramework.Forms.MetroForm
    {
        public deleteUpadateEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLastName.Text = " ";
            txtNic.Text = " ";
            txtPhone.Text = " ";
            txtAddress.Text = " ";
            txtBranch.Text = " ";
            dtStart.Text = " ";
            dtEnd.Text = " ";
            rdioAdmin.Checked = false;
            rdioSales.Checked = false;
            rdioCollector.Checked = false;
            //gridPhoto.DataSource = null;
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                Employee.Employee aa = new Employee.Employee();
                string name = txtLastName.Text;
                //int i = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                //var nameSplit = name.Split();
                aa.setFName(txtFirstName.Text);
                aa.setLName(txtLastName.Text);
                aa.setMName(txtMiddleName.Text);
                aa.setNumber(txtPhone.Text);
                aa.setAddress(txtAddress.Text);
                aa.setBranch(txtBranch.Text);
                if (rdioAdmin.Checked)
                {
                    aa.setDesignation(1);
                }
                else if (rdioSales.Checked)
                {
                    aa.setDesignation(2);
                }
                else if (rdioCollector.Checked)
                {
                    aa.setDesignation(3);
                }
                aa.setStartDate(dtStart.Value);
                aa.setEndDate(dtEnd.Value);
                //check whether the passind will work
                aa.setEid(lblEid.Text);

                bool t = aa.updateEmp();
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            string name = txtLastName.Text;
            string phone = txtPhone.Text;

            MySqlDataReader list = null;
            Employee.Employee aa = new Employee.Employee();
            if (name != null && phone==null)
            {
                list =  aa.searchEmployee(name);
            }
            else if(phone !=null && name == null)
            {
                list = aa.searchEmployee(phone);
            }
            else
            {
                MessageBox.Show("Please search by the name and phone number only");
            }
            var dt = new DataTable();
            dt.Load(list);
            gridView.DataSource = dt;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee.Employee aa = new Employee.Employee();
            bool t =  aa.deleteEmp(txtNic.Text);
            if(t)
            {
                MessageBox.Show("Deleted.");
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //complete the code of loading the form
            
            DataGridViewRow dgvr = this.gridView.CurrentRow;
            //if datagridview have a predefined columns then using those objects as:
            this.txtFirstName.Text = dgvr.Cells[this.FName.Name].Value.ToString();
            this.txtMiddleName.Text = dgvr.Cells[this.MName.Name].Value.ToString();
            this.txtLastName.Text = dgvr.Cells[this.LName.Name].Value.ToString();
            this.txtPhone.Text = dgvr.Cells[this.Phone.Name].Value.ToString();
            this.txtNic.Text = dgvr.Cells[this.NIC.Name].Value.ToString();

            string address1 = dgvr.Cells[this.Address1.Name].Value.ToString();
            string address2 = dgvr.Cells[this.Address2.Name].Value.ToString();
            string address3 = dgvr.Cells[this.Address3.Name].Value.ToString();
            string city= dgvr.Cells[this.City.Name].Value.ToString();

            this.txtAddress.Text = address1 + " " + address2 + " " + address3 + " " + city;

            string b =  dgvr.Cells[this.BranchID.Name].Value.ToString();
            ElectroMaster.branch t = new ElectroMaster.branch();
           
            this.txtBranch.Text = t.SearchBranchName(b);

            string y = dgvr.Cells[this.Designation.Name].Value.ToString();
            if(y=="Administrator")
            {
                rdioAdmin.Checked = true;
            }
            else if(y == "SalesMan")
            {
                rdioSales.Checked = true;
            }
            else
            {
                rdioCollector.Checked = true;
            }
            //dateloading ?????
            string dtStart1 = dgvr.Cells[this.StartDate.Name].Value.ToString();
            string dtEnd1 = dgvr.Cells[this.EndDate.Name].Value.ToString();
            
            this.dtStart.Value = Convert.ToDateTime(dtStart1);
            this.dtEnd.Value = Convert.ToDateTime(dtEnd1);

            this.lblEid.Text = dgvr.Cells[this.EID.Name].Value.ToString();
            //Photograph where stored??
        }
    }
    
}
