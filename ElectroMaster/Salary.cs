using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permanetEmp
{
    class Salary
    {
        private string sId { get; }
        private double grossSal { get; }
        private double allowance;
        private double bonus;
        private double commission;
        private double basicSal { get; set; }

       


        public string getSId()
        {
            return sId;

        }
        public double getgrossSal()
        {
            return grossSal;
        }
        public double getAllowance()
        {
            return allowance;
        }

        public void setAllowance(string all)
        {
            this.allowance = Convert.ToDouble(all);
        }

        public double getBonus()
        {
            return bonus;
        }
        public void setBonus(string pbonus)
        {
            this.bonus = Convert.ToDouble(pbonus);
        }

        public double getcommission()
        {
            return this.commission;
        }
        public void setCommission(String com)
        {
            this.commission = Convert.ToDouble(com);
        }

        public double getBasicSal()
        {
            return basicSal;
        }

        public void setBasicSal(String basic)
        {
            this.basicSal = Convert.ToDouble(basic);
        }
    }
}
