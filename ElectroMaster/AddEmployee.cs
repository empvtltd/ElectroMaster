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
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        Boolean flag;
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            flag = false;
            this.Opacity = 0;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (this.Opacity >= 0.0)
                {
                    this.Opacity -= 0.025;
                }
                else
                {
                    timer1.Stop();
                    this.Close();                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
