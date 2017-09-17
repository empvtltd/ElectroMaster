using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searchEmp
{
    public partial class searchEmployee : MetroFramework.Forms.MetroForm
    {
        public searchEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Employee.Employee t = new  Employee.Employee();
            t.searchEmployee(txtsearchEmp);
        }
    }
}
