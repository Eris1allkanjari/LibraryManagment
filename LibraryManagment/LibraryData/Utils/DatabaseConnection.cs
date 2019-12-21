using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Utils {
    public class DatabaseConnection {

        public static  SqlConnection  connect() {
            String connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            

            return connection;
        }
    }
}