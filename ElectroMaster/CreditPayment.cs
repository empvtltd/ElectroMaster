using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class CreditPayment : Payment
    {
        private double DownPayment = 0.0;

        public double getDownPayment()
        {
            return DownPayment;
        }
        public void setDownPayment(double payment)
        {
            this.DownPayment = payment;
        }
    }
}
