using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace permanetEmp
{
    class SalaryAdvance
    {
        private MySqlConnection con;
        private string SID;
        private double amount;
        private DateTime date;


        public string getSId()
        {
            return Convert.ToString(this.SID);
        }

        public void setSID(string pSId)
        {
            this.SID = pSId;
        }

        public string getAmount()
        {
            return Convert.ToString(this.amount);
        }

        public void setAmount(string amt)
        {
            this.amount = Convert.ToDouble(amt);
        }

        public DateTime getDate()
        {
            return date;
        }


        public void setDate(DateTime pdate)
        {
            this.date = pdate;
        }
        public bool addSalaryAdvance()
        {

            try
            {
                string p = date.ToShortDateString();
                Console.WriteLine(p);
                string query = "insert into electro_master_pvt_ltd.salaryadvance(SID,Amount,date) values"
                    + "(@SID,@AMOUNT,@DATE)";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);


                cmd.Parameters.AddWithValue("@SID", SID);
                cmd.Parameters.AddWithValue("@AMOUNT", amount);
                cmd.Parameters.AddWithValue("@DATE", p);
                      
                return true;




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
                  
        }
        public bool updateSalaryAdvance()
        {

            try
            {
                string p = date.ToShortDateString();
                Console.WriteLine(p);
                string query = "update electro_master_pvt_ltd.salaryadvance set Amount = @AMOUNT"
                    + "where  @EID,@DATE)";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);


                cmd.Parameters.AddWithValue("@EID", SID);
                cmd.Parameters.AddWithValue("@AMOUNT", amount);
                cmd.Parameters.AddWithValue("@DATE", p);

                return true;




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }
        public bool deleteSalaryAdvance(string keyword )
        {
            try
            {


                string query = "delete from electro_master_pvt_ltd.salaryadvance where SID = '" + keyword + "'and Date = @DATE";


                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                //MySqlDataReader reader = conn.readerSQL(query);

                cmd.Parameters.AddWithValue("@DATE", date);
               

                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

        }


    }
}
