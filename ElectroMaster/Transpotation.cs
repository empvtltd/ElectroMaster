using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class Transpotation
    {
        private int TripID = 0;
        private String Source = null;
        private String Destination = null;
        private double StartMileage = 0.0;
        private double TerminationMileage = 0.0;

        public int getTripID()
        {
            return TripID;
        }
        public void setTripID(int id)
        {
            this.TripID = id;
        }

        public String getSource()
        {
            return Source;
        }
        public void setSource(String source)
        {
            this.Source = source;
        }

        public String getDestination()
        {
            return Destination;
        }
        public void setDestination(String destinantion)
        {
            this.Destination = destinantion;
        }

        public double getStartMileage()
        {
            return StartMileage;
        }
        public void setStartMileage(double smileage)
        {
            this.StartMileage = smileage;
        }

        public double getTerminationMileage()
        {
            return TerminationMileage;
        }
        public void setTerminationMileage(double endmileage)
        {
            this.TerminationMileage = endmileage;
        }
    }
}
