using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace judovan.DAL
{
    public class DalDbConn
    {
        public SqlConnection GetConnection()
        {
            SqlConnection dbConn;
            String connString = ConfigurationManager.ConnectionStrings["judovan"].ConnectionString;

            dbConn = new SqlConnection(connString);

            return dbConn;
        }
    }
}