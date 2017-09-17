using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectioTest
{
    class DBMysqlUtils 
    {
        public MySqlConnection connection;
        public MySqlTransaction transaction;
        
        //Create Connection

        public  MySqlConnection GetDBConnection()
        {
             string constring = "Server=43.255.154.44;Port=3306;Database=electro_master_pvt_ltd;username=emideal;password=emideal@#1";
             connection = new MySqlConnection(constring);
             return connection;
        }
        //Open Connection
        public void openConnection()
        {
            connection.Close();
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        //Close Connection
        public void closeConnection()
        {
            transaction.Commit();
            connection.Close();
        }

        //Execute Sql Query

        public void ExecuteSQL(string sSql)
        {
            MySqlCommand cmd = new MySqlCommand(sSql, connection);
            cmd.ExecuteNonQuery();
            System.Windows.Forms.MessageBox.Show("Saved");
        }

        public MySqlDataReader readerSQL(string sSql)
        {
            MySqlCommand cmd = new MySqlCommand(sSql, connection);
            MySqlDataReader readerSql = cmd.ExecuteReader();

            return readerSql;
        }

        
    }

    
}

    

