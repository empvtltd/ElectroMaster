using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace permanetEmp
{
    public class Department
    {
        private MySqlConnection con;
        private String Did;
        private String Dname;

        public string getDid()
        {
            return Did;
        }
        public string  setDid(string pid)
        {
            this.Did = pid;
            return " ";
        }

        public string setDname(string dname)
        {
            this.Dname = dname;
            return " ";
        }

        public string getDname()
        {

            return Dname;
        }
        public string SearchDeaprtmentID(string pDepartment)
        {
            try
            {

                string query = "select Dep_DepID from department where Dep_DName = ' pDepartment' ";
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string DID = reader["Br_BranchID"].ToString();
                        Did = DID;
                    }
                }
                return Did;

            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return null;
            }

        }
    }


}
