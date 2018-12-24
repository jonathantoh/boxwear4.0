using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace boxwear.DAL
{
    public class DalPurchaseOrders
    {
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        private string msg;
        public DataSet GetPOList()
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM PurchaseOrders");
            sql.AppendLine("ORDER BY PoID DESC");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return ProgramData;
        }



        


        public DataSet GetPOListFiltered(string status)
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM PurchaseOrders");
            sql.AppendLine("WHERE PoStatus = @PS");
            sql.AppendLine("ORDER BY PoID DESC");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("PS", status);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return ProgramData;
        }

        public int GetPoID()
        {
            int PO;
            SqlConnection conn = dbConn.GetConnection();
            SqlCommand getPO = new SqlCommand("SELECT MAX(PoID) FROM PurchaseOrders", conn);
            conn.Open();
            PO = Convert.ToInt32(getPO.ExecuteScalar());
            conn.Close();
            return PO;
        }

        public int CreatePOI(int productID, string productName, int quantity, decimal unitPrice, decimal totalPrice)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO Item(ProductID, ProductName, ProductQty, UnitPrice, TotalPrice)");
            sql.AppendLine("VALUES (@productID, @productName, @productQty, @UnitPrice,@TotalPrice)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@productQty", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                // cmd.Parameters.AddWithValue("@PoID", PoID);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

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


        public int CreatePO(string PODate, string POStatus, decimal totalAmt,string companyName, string supplierName)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO PurchaseOrders(PoDate, PoStatus, PoTotalAmt, CompanyName, SupplierName)");
            sql.AppendLine("VALUES (@PODate, @POStatus, @TotalAmt, @CompanyName,@SupplierName)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@PODate", PODate);
                sqlCmd.Parameters.AddWithValue("@POStatus", POStatus);
                sqlCmd.Parameters.AddWithValue("@TotalAmt", totalAmt);
                sqlCmd.Parameters.AddWithValue("@CompanyName", companyName);
                sqlCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                result = sqlCmd.ExecuteNonQuery();
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