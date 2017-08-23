using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class SalesPoint
    {
        private String SalesPointID = null;
        private String Location = null;
        private DateTime Date ;
        private double Budget = 0.0;

        public String getSalesPointID()
        {
            return SalesPointID;
        }
        public void setSalesPointID(String id)
        {
            this.SalesPointID = id;
        }

        public String getLocation()
        {
            return Location;
        }
        public void seLocation(String location)
        {
            this.Location = location;
        }

        public DateTime getDate()
        {
            return Date;
        }
        public void setDate(DateTime date)
        {
            this.Date = date;
        }

        public double getBudget()
        {
            return Budget;
        }

        public void setBudget(double budget)
        {
            this.Budget = budget;
        }

    }
}
