using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHourWork
{
    public class Database
    {
        public MySqlConnection connection;
        public Database(MySqlConnection connection)
        {
            this.connection = connection;
        }

        public Database(MySqlConnection connection, string server, int port, string nameDb, string userId, string pass)
        {
            this.connection = connection;
        }
    }
}
