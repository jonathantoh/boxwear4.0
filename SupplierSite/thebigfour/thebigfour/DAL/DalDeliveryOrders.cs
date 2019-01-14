using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace thebigfour.DAL
{
    public class DalDeliveryOrders
    {
        private string msg;
        DalDbConn dbConn = new DalDbConn();

        public int DeliveryInsert(int PoID, int prodID, string prodDesc, int productQty, string status, string date)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO DeliveryOrders(PoID,ProductID,ProdDesc,ProductQty,DeliveryStatus,DeliveryDate)");
            sql.AppendLine("VALUES (@poID, @prodID, @prodDesc, @prodQty, @status, @date)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@poID", PoID);
                cmd.Parameters.AddWithValue("@prodID", prodID);
                cmd.Parameters.AddWithValue("@prodDesc", prodDesc);

                cmd.Parameters.AddWithValue("@prodQty", productQty);
                cmd.Parameters.AddWithValue("@status",status );
                cmd.Parameters.AddWithValue("@date", date);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}