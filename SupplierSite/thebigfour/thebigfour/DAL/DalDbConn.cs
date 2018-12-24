using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace thebigfour.DAL
{
    public class DalDbConn
    {
        public SqlConnection GetConnection()
        {
            SqlConnection dbConn;
            String connString = ConfigurationManager.ConnectionStrings["thebigfour"].ConnectionString;

            dbConn = new SqlConnection(connString);

            return dbConn;
        }
    }
}