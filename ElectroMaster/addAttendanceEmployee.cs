using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addAttendance
{
    public partial class addAttendanceEmployee : MetroFramework.Forms.MetroForm
    {
        public addAttendanceEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            
            permanetEmp.attendance aa= new permanetEmp.attendance();
            aa.setEmpId(txtEmpID.Text);
            //aa.setDate(txtDate.Text.Date);
            aa.setDate(DateTime.ParseExact(txtDate.Text, "yyyy-mm-dd",System.Globalization.CultureInfo.InvariantCulture));
            aa.setInam(DateTime.ParseExact(txtDate.Text, "yyyy-mm-dd", System.Globalization.CultureInfo.InvariantCulture));
            
        }
    }
}
