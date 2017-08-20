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
    public partial class NewSalesPointView : MetroFramework.Forms.MetroForm
    {
        public NewSalesPointView()
        {
            InitializeComponent();
        }

        private void NewSalesPointView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new NewCustomer();
            myForm.Show();
            this.Dispose();
        }
    }
}
