using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace thebigfour.DAL
{
   
    public class DalViewPurchaseOrder
    {
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        public DataSet GetAllPurchaseOrder()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet booksData;

            SqlConnection conn = dbConn.GetConnection();
            booksData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * ");
            sql.AppendLine("FROM ViewPurchaseOrder");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(booksData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return booksData;
        }
    }
}