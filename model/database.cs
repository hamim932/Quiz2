using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connetionString = "Server = HAMIM\\HAMIMHASAN; Database =DBMS; User Id = 123; Password = 0000";
            SqlConnection conn = new SqlConnection(connetionString);
            Books = new Books(conn);
        }
    }
}
