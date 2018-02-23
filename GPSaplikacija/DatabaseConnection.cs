using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQLConnection = MySql.Data.MySqlClient.MySqlConnection;
using MySQLCommand = MySql.Data.MySqlClient.MySqlCommand;

namespace GPSaplikacija
{
    static class DatabaseConnection
    {
        public static MySQLConnection sqlConn =
            new MySQLConnection("database="+ DatabaseData.database +
                                ";server=" + DatabaseData.host +
                                ";user id=" + DatabaseData.username +
                                ";pwd=" + DatabaseData.password);

        public static MySQLCommand sqlCmd = new MySQLCommand();
        
        public static void CheckSqlConnection()
        {
            if (sqlConn.State == System.Data.ConnectionState.Closed)
                sqlConn.Open();
        }
    }
}
