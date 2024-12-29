using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectDLL
{
    public class DataBase
    {
        public static SqlConnection conn = new SqlConnection("Server=DESKTOP-GEM7OTA\\SQLEXPRESS;DataBase=OOP-Project;Trusted_Connection=True;");
        public static void openConnection()
        {
            conn.Open();

        }
        public static void closeConnection()
        {
            conn.Close();

        }
    }
}
