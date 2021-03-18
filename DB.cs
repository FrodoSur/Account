using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class DB
    {
        MySqlConnection connection;
        public DB(String hostName, int port, String userName,String password, String dataBase)
        {
            String s = "server="+ hostName+";port="+port.ToString()+";username="+userName+";password="+password+";database="+dataBase;
            connection = new MySqlConnection(s);
        }
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
