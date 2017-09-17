using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroMaster
{
    class branch
    {
        private MySqlConnection con;
        private string branchID = null;
        private string branchName = null;

        public void setBranchID(string pbranchID)
        {
            this.branchID = pbranchID;
        }
        public string getBranchID()
        {
            return branchID;
        }
        public void setBranchName(string pBranchName)
        {
            this.branchName = pBranchName;
        }
        public string getBranchName()
        {
            return branchName;
        }

        public bool addBranch()
        {
            try
            {

                string query = "insert into electro_master_pvt_ltd.branch(Br_BranchID,Br_Bname) "
                    +"values ('" + branchID + "','" + branchName + "')";

                // MySqlConnection conn = new MySqlConnection();
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);

                while (reader.Read()) { }

                return true;


            }        
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
       
           
        }
        public string  SearchBranchID(string pBranchName)
        {
            try
            {

                string query = "select Br_BranchID from electro_master_pvt_ltd.branch where "
                    +"Br_BName = '" + pBranchName+"' ";
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();


               
                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string BranchID = reader["Br_BranchID"].ToString();
                        branchID = BranchID;
                    }
                }
                return branchID;

            }
            catch(Exception er)
            {
                Console.WriteLine(er);
                return null;
            }
            
        }
        public string SearchBranchName(string pBranchID)
        {
            try
            {

                string query = "select Br_BName from electro_master_pvt_ltd.branch where"
                    +"Br_BranchID= '" + pBranchID+"'";
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();



                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string BranchName = reader["Br_BName"].ToString();
                        branchName = BranchName;
                    }
                }
                return branchName;

            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return null;
            }

        }
        public bool deleteBranch(string keyword)
        {
            try
            {
                string query = "delete from electro_master_pvt_ltd.branch where Br_BranchID = '" + keyword + "'"
                   +" or Br_BName ='"+keyword+"'";


                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);

                while (reader.Read()) { }

                return true;
            }
            catch(Exception er)
            {
                Console.WriteLine(er);
                return false;
            }
            
        }
        //allows only to update the Branch Name
        public bool updateBranchName()
        {
            try
            {
                
                string query = "update electro_master_pvt_ltd.branch set Br_BranchName  = '"+branchName+"' "
                    + "where Br_BranchID = '"+branchID+"' ";

                //making the object from the DBMySqlUtils 
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                //calling the method that return the connection
                con = conn.GetDBConnection();
                //open the connection
                con.Open();

                MySqlDataReader reader = conn.readerSQL(query);

                while (reader.Read()) { }

                return true;
            }
            catch(Exception er)
            {
                Console.WriteLine(er);
                return false;
            }
        }
        //Retrieve all the information from the DB connection is required!!
        public MySqlDataReader searchBranch(string keyword)
        {
            
            try
            {
                string query = "select * from electro_master_pvt_ltd.branch where Br_BranchID like '%" + keyword + "%' or Br_BName like '%" + keyword + "%'";

                //making the object using the db class
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();
                                
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                

                //con.Close();

                return dataReader;
            }
            catch(Exception er)
            {
                Console.WriteLine(er);
                return null;
            }
        }  


    }
}
