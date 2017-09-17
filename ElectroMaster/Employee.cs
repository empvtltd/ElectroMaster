using MySql.Data.MySqlClient;
using permanetEmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public class Employee
    {

        private MySqlConnection con;
        private string fname = null;
        private string mname= null;
        private string lname = null;
        private string Eid = null;
        private string Nic = null;
        private string address1= null;
        private string address2 = null;
        private string address3 = null;
        private string city = null;
        private string number = null;
        private DateTime startDate;
        private string designation = null;
        private DateTime endDate;
        private string branch = null;
        private string department = null;
        private string Sid = null;

        public void setFName(string pfname)
        {
            this.fname = pfname;
        }

        public string getFName()
        {
            return this.fname;
        }
        public void setMName(string pmname)
        {
            this.mname = pmname;
        }

        public string getMName()
        {
            return this.mname;
        }
        public void setLName(string plname)
        {
            this.lname = plname;
        }

        public string getLName()
        {
            return this.lname;
        }
        public string getFullName()
        {
            return this.fname + " " + this.mname + " " + this.lname;
        }
        public void setEid(string pEid)
        {
            this.Eid = pEid;
        }

        public void setNic(string pNic)
        {
            this.Nic = pNic;
        }

        public string getNic()
        {
            return this.Nic;
        }

        public void setAddress(string paddress)
        {
            var address = paddress.Split(' ',',');
            this.address1 = address[0];
            this.address2 = address[1];
            this.address3 = address[2];
            this.city = address[3];         
            
        }

        public string getAddress()
        {
            return this.address1+" "+this.address2+" "+ this.address3 + " " + this.city ;
        }

        public void setNumber(string pnum)
        {
            this.number = pnum;
        }

        public int getNumberInt()
        {
            int IntNumber = 0;
            IntNumber = Convert.ToInt32(this.number);

            return IntNumber;
        }
        public String getNumberString()
        {
            return number;
        }
        public void setStartDate(DateTime pdate)
        {
            this.startDate = pdate;
        }
        public string getDate()
        {
            return Convert.ToString(startDate);
        }
        public void setDesignation(int pdesignation)
        {
            switch (pdesignation)
            {
                case 1:this.designation = "Administrator";
                    this.department = "Administration"; break;
                case 2:this.designation = "SalesMan"; this.department = "Sales"; break;
                case 3:this.designation = "Collector"; this.department = "Collection"; break;
            }
             
        }
       /* public void setDesignationText(string desig)
        {
            if(desig== "Administrator"|| desig == "administrator")
            {
                this.designation = "Administrator";
                this.department = "Administration";
            }
            else if(desig== "SalesMan"|| desig == "salesMan")
            {
                this.designation = "SalesMan";
                this.department = "Sales";
            }
            else if (desig == "Collector"|| desig == "collector")
            {
                this.designation = "Collector";
                this.department = "Collection";
            }
            
        }*/
        public string getDesgnation()
        {
            return this.designation;
        }
        public void setEndDate(DateTime value)
        {
            this.endDate = value;
        }
        public DateTime getEndDate()
        {
            return this.endDate;
        }
        public void setBranch(string pBranch)
        {
            this.branch = pBranch;
        }
        public string getBranch()
        {
            return branch;
        }
        public void setDepartment(string pdepartment)
        {
            this.department = pdepartment;
        }
        public string getDepartment()
        {
            return department;
        }
        public void setSid(string pSid)
        {
            this.Sid = pSid;
        }
        public string getSid()
        {
            return this.Sid;
        }
        public bool updateEmp()
        {

            try
            {
                //complete the query
                /*string query = null;
                if (col == "name")
                {
                    query = "update electro_master_pvt_ltd.employee set Fname = ? , Mname = ? ,Lname=? , Address_1= ?,Address_2 = ?,Address_3=?, City=?,.........where Fname= keyword or Mname = keyword or lname = keyword)";
                }
                else if (col == "phone")
                {
                    query = "update electro_master_pvt_ltd.employee set Fname = ? , Mname = ? ,Lname=? , Address_1= ?,Address_2 = ?,Address_3=?, City=?,.........where phone = keyword)";
                }*/
                ElectroMaster.branch t = new ElectroMaster.branch();
                string branchID = t.SearchBranchID(branch);

                Department r = new Department();
                string departmentID = r.SearchDeaprtmentID(department);

                string query = "update electro_master_pvt_ltd.employee set Emp_Fname = @FNAME  , Emp_Mname = @MNAME , Emp_Lname=@LNAME , "
                   + " Emp_Address1 = @ADDRESS1 , Emp_Adress2 = @ADDRESS2 , Emp_Address3 = @ADDRESS3 , Emp_city = @CITY  , Emp_BranchID = @BRANCH , "
                   + "Emp_StartDate = @STARTDATE , Emp_DepID = @DEPARTMEN , Emp_NIC= @NIC , Emp_EndDate = @ENDDATE where EmployeeID =@EID";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                                        
                con = conn.GetDBConnection();
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@EID", Eid);
                cmd.Parameters.AddWithValue("@FNAME", fname);
                cmd.Parameters.AddWithValue("@MNAME", mname);
                cmd.Parameters.AddWithValue("@LNAME", lname);
                cmd.Parameters.AddWithValue("@NIC", Nic);
                cmd.Parameters.AddWithValue("@ADDRESS1", address1);
                cmd.Parameters.AddWithValue("@ADDRESS2", address2);
                cmd.Parameters.AddWithValue("@ADDRESS3", address3);
                cmd.Parameters.AddWithValue("@CITY", city);
                cmd.Parameters.AddWithValue("@NUMBER", number);
                cmd.Parameters.AddWithValue("@STARTDATE", startDate);
                cmd.Parameters.AddWithValue("@ADDRESS2", address2);
                cmd.Parameters.AddWithValue("@ADDRESS3", address3);
                cmd.Parameters.AddWithValue("@CITY", city);
                cmd.Parameters.AddWithValue("@NUMBER", number);
                cmd.Parameters.AddWithValue("@STARTDATE", startDate);
                cmd.Parameters.AddWithValue("@DESIGNATION", designation);
                cmd.Parameters.AddWithValue("@ENDDATE", endDate);
                cmd.Parameters.AddWithValue("@BRANCH", branchID);
                cmd.Parameters.AddWithValue("@DEPARTMENT", departmentID);
            
                cmd.ExecuteNonQuery();

                
                return true;

                /* MySqlCommand command = new MySqlCommand(query);

                 if (command.ExecuteNonQuery() == 1)
                 {
                     MessageBox.Show("Query executed");
                 }
                 else
                 {
                     MessageBox.Show("Query not executed");
                 }*/
                // MySqlDataReader reader = command.ExecuteReader();
                

            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return false;
            }
        }

        public bool deleteEmp(string keyword)
        {
            try
            {
                

                string query = "delete from electro_master_pvt_ltd.employee where Emp_NIC= '" + keyword + "'";


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
            finally
            {
                con.Close();
            }
            
        }

       
        public bool addEmployee()
        {
            try
            {
                
                /*string currentdate = DateTime.Now.ToString();
                var i = currentdate.Split(' ');
                DateTime current = Convert.ToDateTime(i[0]);*/

                ElectroMaster.branch t = new ElectroMaster.branch();
                string branchID = t.SearchBranchID(branch);

                Department r = new Department();
                string departmentID = r.SearchDeaprtmentID(department);

                this.AutoGenerateEID();


                string query = "insert into electro_master_pvt_ltd.employee(EmployeeID , Emp_Fname,Emp_Mname,Emp_Lname,"
                   + " Emp_Address1,Emp_Adress2,Emp_Address3,Emp_city,Emp_BranchID,Emp_StartDate,Emp_DepID,Emp_NIC)"
                   + "values (@EID , @FNAME , @MNAME , @LNAME , @ADDRESS1 , @ADDRESS2 , @ADDRESS3 , @CITY , @BRANCH , @STARTDATE , @DEPARTMENT , @NIC)";


                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                //MySqlDataReader reader = conn.readerSQL(query);

                cmd.Parameters.AddWithValue("@EID", Eid);
                cmd.Parameters.AddWithValue("@FNAME", fname);
                cmd.Parameters.AddWithValue("@MNAME", mname);
                cmd.Parameters.AddWithValue("@LNAME", lname);
                cmd.Parameters.AddWithValue("@NIC", Nic);
                cmd.Parameters.AddWithValue("@ADDRESS1", address1);
                cmd.Parameters.AddWithValue("@ADDRESS2", address2);
                cmd.Parameters.AddWithValue("@ADDRESS3", address3);
                cmd.Parameters.AddWithValue("@CITY", city);
                cmd.Parameters.AddWithValue("@NUMBER", number);
                cmd.Parameters.AddWithValue("@STARTDATE", startDate);
                cmd.Parameters.AddWithValue("@ADDRESS2", address2);
                cmd.Parameters.AddWithValue("@ADDRESS3", address3);
                cmd.Parameters.AddWithValue("@CITY", city);
                cmd.Parameters.AddWithValue("@NUMBER", number);
                cmd.Parameters.AddWithValue("@STARTDATE", startDate);
                cmd.Parameters.AddWithValue("@DESIGNATION", designation);
                cmd.Parameters.AddWithValue("@ENDDATE", endDate);
                cmd.Parameters.AddWithValue("@BRANCH", branchID);
                cmd.Parameters.AddWithValue("@DEPARTMENT", departmentID);

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
                this.closeAllConnection();
            }

            
        }
        private void closeAllConnection()
        {
            throw new NotImplementedException();
        }

        /*public List<string>[] searchEmployee(string keyword)
        {
            List<string>[] list = new List<string>[16];
            try
            {
                //Create a list to store the result
                

                string query = "select * from electro_master_pvt_ltd.employee where Emp_Fname like '%" + keyword+"%' or "
                    + "Emp_Mname like  '%" + keyword+ "%'  or  Emp_Lname like '%" + keyword+ "%' or Emp_Phone like '%" + keyword + "%' ";


                //Create a list to store the result
                
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();
                list[4] = new List<string>();
                list[5] = new List<string>();
                list[6] = new List<string>();
                list[7] = new List<string>();
                list[8] = new List<string>();
                list[9] = new List<string>();
                list[10] = new List<string>();
                list[11] = new List<string>();
                list[12] = new List<string>();
                list[13] = new List<string>();
                list[14] = new List<string>();
                list[15] = new List<string>();


                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                //open conncetion
                con.Open();                

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["EmployeeID"] + "");
                    list[1].Add(dataReader["Emp_Fname"] + "");
                    list[2].Add(dataReader["Emp_Mname"] + "");
                    list[3].Add(dataReader["Emp_Lname"] + "");
                    list[4].Add(dataReader["Emp_Address1"] + "");
                    list[5].Add(dataReader["Emp_Address2"] + "");
                    list[6].Add(dataReader["Emp_Address3"] + "");
                    list[7].Add(dataReader["Emp_City"] + "");
                    list[8].Add(dataReader["Emp_BranchID"] + "");
                    list[9].Add(dataReader["Emp_StartDate"] + "");
                    list[10].Add(dataReader["Emp_EndDate"] + "");
                    list[11].Add(dataReader["Emp_DepID"] + "");
                    list[12].Add(dataReader["Emp_SalID"] + "");
                    list[13].Add(dataReader["Emp_NIC"] + "");
                    list[14].Add(dataReader["Emp_Phone"] + "");
                    list[15].Add(dataReader["Emp_Designation"] + "");

                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                con.Close();

                //return list to be displayed
                return list;
                


                

            }
            catch(Exception er)
            {
                Console.WriteLine(er);
                return list; 
              
            }
           
        }*/
        public MySqlDataReader searchEmployee(string keyword)
        {
            
            try
            {
               


                string query = "select * from electro_master_pvt_ltd.employee where Emp_Fname like '%" + keyword + "%' or "
                    + "Emp_Mname like  '%" + keyword + "%'  or  Emp_Lname like '%" + keyword + "%' or Emp_Phone like '%" + keyword + "%' ";


                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();

                //open conncetion
                con.Open();

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, con);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();                            

               
                //return list to be displayed
                return dataReader;





            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return null;

            }

        }

       
       public string searchName(string pNIC)
        {
            try
            {
                string fname = null;
                string mname = null;
                string lname = null;
                string name = null;

                string query = "select Emp_Fname,Emp_Mname , Emp_Lname  from "
                    + "electro_master_pvt_ltd.branch where Emp_NIC = '" + pNIC + "'";
                    
                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();



                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        fname= reader["Emp_Fname"].ToString();
                        mname = reader["Emp_Mname"].ToString();
                        lname = reader["Emp_Lname"].ToString();
                        name = fname + " " + mname + " " + lname;
                    }
                }
                return name;

            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return null;
            }

        }
        public string searchSID(string pNIC)
        {

            try
            {
                string sid = null;
                string query = "select Emp_SalID  from "
                    + "electro_master_pvt_ltd.branch where Emp_NIC = '" + pNIC + "'";

                ConnectioTest.DBMysqlUtils conn = new ConnectioTest.DBMysqlUtils();
                con = conn.GetDBConnection();



                con.Open();
                MySqlDataReader reader = conn.readerSQL(query);
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        sid = reader["Emp_SalID"].ToString();
                       
                    }
                }
                return sid;

            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                return null;
            }
        }
        public void AutoGenerateEID()
        {
            string prefix = null;
            if(designation== "Administrator")
            {
                prefix = "ADM";
            }
            else if (designation== "SalesMan")
            {
                prefix = "SAL";
            }
            else if(designation == "Collector")
            {
                prefix = "COL";
            }

            Eid = prefix + Nic;

           
        }




    }
   
}
