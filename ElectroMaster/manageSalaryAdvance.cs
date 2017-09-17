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
    public partial class manageSalaryAdvance : MetroFramework.Forms.MetroForm
    {
        public manageSalaryAdvance()
        {
            InitializeComponent();
        }

        private void manageSalaryAdvance_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            permanetEmp.SalaryAdvance p = new permanetEmp.SalaryAdvance();

            p.setAmount(txtAmount.Text);
            p.setDate(dtDate.Value.Date);
            string nic = txtEmpNIC.Text;

            Employee.Employee tr = new Employee.Employee();
            
            p.setSID(tr.searchSID(nic));

            bool t = p.addSalaryAdvance();
            if (t == true)
            {
                MessageBox.Show("Saved!!");
            }
            else
            {
                MessageBox.Show("Not Saved!!");
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            permanetEmp.SalaryAdvance p = new permanetEmp.SalaryAdvance();

            p.setAmount(txtAmount.Text);
            p.setDate(dtDate.Value.Date);
            string nic = txtEmpNIC.Text;

            Employee.Employee tr = new Employee.Employee();

            p.setSID(tr.searchSID(nic));

            bool t = p.updateSalaryAdvance();
            if (t == true)
            {
                MessageBox.Show("Updated!!");
            }
            else
            {
                MessageBox.Show("Not Updated!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            permanetEmp.SalaryAdvance aa = new permanetEmp.SalaryAdvance();
            aa.setDate(dtDate.Value);

            Employee.Employee o = new Employee.Employee();
            string pSId = o.searchSID(txtEmpNIC.Text);

            bool t = aa.deleteSalaryAdvance(pSId);
            if (t)
            {
                MessageBox.Show("Deleted.");
            }
            else
            {
                MessageBox.Show("Not Deleted.");
            }
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
