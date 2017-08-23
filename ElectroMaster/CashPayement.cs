using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class CashPayement : Payment
    {
        private double Amount = 0.0;

        public double getAmount()
        {
            return Amount;
        }
        public void setAmount(double amount)
        {
            this.Amount = amount;
        }
    }
}
