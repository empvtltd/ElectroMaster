using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class Payment
    {
        private int PaymentID = 0;
        private DateTime Date;
        private double Discount = 0.0;

        public int getPaymentID()
        {
            return PaymentID;
        }
        public void setPaymentID(int payID)
        {
            this.PaymentID = payID;
        }

        public DateTime getDate()
        {
            return Date;
        }
        public void setDate(DateTime date)
        {
            this.Date = date;
        }

        public double getDiscount()
        {
            return Discount;
        }
        public void setDiscount(double discount)
        {
            this.Discount = discount;
        } 
    }
}
