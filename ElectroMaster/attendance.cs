using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace permanetEmp
{
    class attendance
    {
        private MySqlConnection con;


        private string EmpID = null;
        private DateTime in_time_am;
        private DateTime out_time_am;
        private DateTime date;
        private DateTime in_time_pm;
        private DateTime out_time_pm;
        private double OTHrs = 0.0;
        private DateTime Off_startDate;
        private DateTime Off_endDate;
        private DateTime Off_startTime;
        private DateTime Off_endTime;
        private string Off_Type = null;



        public string getEmpId()
        {
            return EmpID;
        }
        public void setEmpId(string pEmpid)
        {
            this.EmpID = pEmpid;
        }
        public void setDate(DateTime pdate)
        {
            this.date = pdate;
        }
        public DateTime getDate()
        {
            return this.date;
        }

        public DateTime getInPm()
        {
            return in_time_pm;
        }

        public void setInpm(DateTime pinPm)
        {
            this.in_time_pm = pinPm;
        }
        public DateTime getInAm()
        {
            return in_time_am;
        }

        public void setInam(DateTime pinAm)
        {
            this.in_time_am = pinAm;
        }
        public DateTime getOutPm()
        {
            return out_time_pm;
        }

        public void setOutPm(DateTime poutPm)
        {
            this.out_time_pm = poutPm;
        }
        public DateTime getOutAm()
        {
            return out_time_am;
        }

        public void setOutAm(DateTime poutAm)
        {
            this.out_time_am = poutAm;
        }
        public string getOTHrs()
        {
            return Convert.ToString(this.OTHrs);
        }
        public void setOTHrs(string pot)
        {
            this.OTHrs = Convert.ToDouble(pot);
        }
        public void setOff_StartDate(DateTime pstDate)
        {
            this.Off_startDate = pstDate;
        }
        public DateTime getOff_StartDate()
        {
            return this.Off_startDate;
        }
        public void setOff_endDate(DateTime pedDate)
        {
            this.Off_endTime = pedDate;
        }
        public DateTime getOff_endDate()
        {
            return this.Off_endTime;
        }
        public void setOff_startTime(DateTime pstTime)
        {
            this.Off_startTime = pstTime;
        }
        public DateTime getOff_startTime()
        {
            return this.Off_startTime;
        }
        public void setOff_endTime(DateTime pendtime)
        {
            this.Off_endTime = pendtime;
        }
        public DateTime getOff_endTime()
        {
            return this.Off_endTime;
        }

        public Boolean MarkAmIN()
        {
            try
            {
                string query = "insert into electro_master_pvt_ltd.attendace ()values ()";
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);

                while (reader.Read()) { }


                return true;



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            

            
        }
        
        public bool addOffDaysDay()
        {
            try
            {
                string query = "insert into electro_master_pvt_ltd.employee_OffDays(Emp_ID , StartDate , EndDate , Type ) values (@EID , @STARTDATE , @ENDDATE  "
                    + "  , @TYPE)";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();


                MySqlCommand cmd = new MySqlCommand(query,con);
                cmd.Parameters.AddWithValue("@EID", EmpID);
                cmd.Parameters.AddWithValue("@STARTDATE", Off_startDate);
                cmd.Parameters.AddWithValue("@ENDDATE", Off_endDate);
                //cmd.Parameters.AddWithValue("@STARTTIME", Off_startTime);
                //cmd.Parameters.AddWithValue("@ENDTIME", Off_endTime);
                cmd.Parameters.AddWithValue("@TYPE", Off_Type);
                

                cmd.ExecuteNonQuery();

                //MySqlDataReader reader = command.ExecuteReader();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
           
           
        }
        public bool addOffDaysTime()
        {
            try
            {
                string query = "insert into electro_master_pvt_ltd.employee_OffDays(Emp_ID , StartDate , EndDate , Type , StartTime , EndTime) values (@EID , @STARTDATE , @ENDDATE  "
                    + "  , @TYPE , @STARTTIME , @ENDTIME )";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();


                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EID", EmpID);
                cmd.Parameters.AddWithValue("@STARTDATE", Off_startDate);
                cmd.Parameters.AddWithValue("@ENDDATE", Off_startDate);
                cmd.Parameters.AddWithValue("@STARTTIME", Off_startTime);
                cmd.Parameters.AddWithValue("@ENDTIME", Off_endTime);
                cmd.Parameters.AddWithValue("@TYPE", Off_Type);


                cmd.ExecuteNonQuery();

                //MySqlDataReader reader = command.ExecuteReader();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
