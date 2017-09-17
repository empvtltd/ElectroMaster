using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ElectroMaster
{
    public partial class manageBranch : MetroFramework.Forms.MetroForm
    {
        public manageBranch()
        {
            InitializeComponent();
        }

        private void addBranch_Load(object sender, EventArgs e)
        {
            
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ElectroMaster.branch p = new ElectroMaster.branch();
            //p.setBranchID(txtBranchID.Text);
            //p.setBranchName(txtBranchName.Text);

            bool rslt = false;
            validations.validations o = new validations.validations();
            if (o.isEmpty(txtBranchID.Text))
            {
                rslt = p.deleteBranch(txtBranchName.Text);
            }
            else if (o.isEmpty(txtBranchName.Text))
            {
                rslt = p.deleteBranch(txtBranchID.Text);
            }

            if (rslt == true)
            {
                MessageBox.Show("Deleted.");
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            ElectroMaster.branch p = new ElectroMaster.branch();
            //p.setBranchID(txtBranchID.Text);
            //p.setBranchName(txtBranchName.Text);

            MySqlDataReader reader= null;

            //assign a variable to get the resulting tuples 
            validations.validations o = new validations.validations();
            if (o.isEmpty(txtBranchID.Text))
            {
                reader = p.searchBranch(txtBranchName.Text);
            }
            else if (o.isEmpty(txtBranchName.Text))
            {
                reader = p.searchBranch(txtBranchID.Text);
            }
            // loading to the grid view should be completed ?????

            var dt = new DataTable();
            dt.Load(reader);
            gridViewBranch.DataSource = dt;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ElectroMaster.branch p = new ElectroMaster.branch();
            p.setBranchID(txtBranchID.Text);
            p.setBranchName(txtBranchName.Text);

            bool t = p.addBranch();
            if(t)
            {
                MessageBox.Show("Saved.");
            }
            else
            {
                MessageBox.Show("Not Saved.");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ElectroMaster.branch p = new ElectroMaster.branch();
            p.setBranchID(txtBranchID.Text);
            p.setBranchName(txtBranchName.Text);

            bool rslt =false;

            rslt = p.updateBranchName();

            if (rslt == true)
            {
                MessageBox.Show("Updated.");
            }
            else
            {
                MessageBox.Show("Not Updated.");
            }

        }

        private void gridViewBranch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.gridViewBranch.CurrentRow;
            this.txtBranchID.Text = dgvr.Cells[this.BranchID.Name].Value.ToString();
            this.txtBranchName.Text = dgvr.Cells[this.BranchName.Name].Value.ToString();

        }
    }
}
