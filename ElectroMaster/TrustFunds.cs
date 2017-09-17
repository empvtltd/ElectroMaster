using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permanetEmp
{
    class TrustFunds
    {
        private string EPFNo { get; }
        private string ETFNo { get; }

        private double EPFAmount=0;
        private double ETFAmount=0;
        private double EPFPct;
        private double ETFPct;

        public string getEPFNo()
        {
            return this.EPFNo;
        }
        public string getETFNo()
        {
            return this.ETFNo;
        }
        public double getEPFAmount()
        {
            return this.ETFAmount;
        }

        public double getEPFPct()
        {
            return this.EPFPct;
        }

        public double getETFPct()
        {
            return this.ETFPct;
        }
        public void setEPFPct(string EPF)
        {
            this.EPFPct = Convert.ToDouble(EPF);
        }
        public void setETFPct(String ETF)
        {
            this.ETFPct = Convert.ToDouble(ETF);
        }

    }
}
