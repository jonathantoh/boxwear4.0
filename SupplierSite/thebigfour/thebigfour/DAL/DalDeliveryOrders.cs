using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using thebigfour.SvcRefJudoVan;

namespace thebigfour.DAL
{
    public class DalDeliveryOrders
    {
        private string msg;
        DalDbConn dbConn = new DalDbConn();

        public int DeliveryInsert(decimal weight, string deliveryStatus, int PoID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty, string company, decimal TotalValue)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Delivery (weight, deliveryStatus, PoID, dateRegistered, deliveryType, ProductDesc, ProductQty, CompanyName, TotalValue)");
            sql.AppendLine("VALUES(@weight, @deliveryStatus, @PoID, @dateRegistered, @deliveryType, @ProductDesc, @ProductQty, @CompanyName, @TotalValue)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@deliveryStatus", deliveryStatus);
                cmd.Parameters.AddWithValue("@PoID", PoID);
                cmd.Parameters.AddWithValue("@dateRegistered", dateRegistered);
                cmd.Parameters.AddWithValue("@deliveryType", deliveryType);
                cmd.Parameters.AddWithValue("@ProductDesc", ProductDesc);
                cmd.Parameters.AddWithValue("@ProductQty", ProductQty);
                cmd.Parameters.AddWithValue("@CompanyName", company);
                cmd.Parameters.AddWithValue("@TotalValue", TotalValue);

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

        public DataSet GetAll()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ds;

            SqlConnection conn = dbConn.GetConnection();
            ds = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * ");
            sql.AppendLine("FROM Delivery");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ds;
        }

        public DataSet GetDeliveryDetailsByID(int id)
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM Delivery");
            sql.AppendLine("WHERE trackingID = @trackingID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("trackingID", id);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return ProgramData;
        }

        public DataSet updateDeliveryInvoice(int id, int InvoiceID)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("UPDATE Delivery");
            sql.AppendLine("SET InvoiceID = @InvoiceID");
            sql.AppendLine("WHERE trackingID = @trackingID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("trackingID", id);
                da.SelectCommand.Parameters.AddWithValue("InvoiceID", InvoiceID);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ProgramData;
        }

        public DataSet updateDOStatus(int id, string status)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("UPDATE Delivery");
            sql.AppendLine("SET deliveryStatus = @POs");
            sql.AppendLine("WHERE trackingID = @trackingID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("trackingID", id);
                da.SelectCommand.Parameters.AddWithValue("POs", status);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ProgramData;
        }

    }
}