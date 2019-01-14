using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace thebigfour.DAL
{
    public class DalCustomerOrders
    {
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        public DataSet GetAllCO()
        {
        
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM CustomerOrder");
            sql.AppendLine("ORDER BY CoNum DESC");

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


        public DataSet GetCODetail(int CONo)
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM CustomerOrderItems WHERE CoNum = @CONo");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("CONo", CONo);
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


        public int InsertCO(int poNum, string comName,string orderDate,decimal totalAmt, string add, string stat)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int inserting;

            inserting = 0;

            sql = new StringBuilder();

            sql.AppendLine("INSERT INTO CustomerOrder (PONum, CompanyName, CoOrderDate, CoTotalAmt, BillingAddress,CoOrderStatus)");
            sql.AppendLine(" ");
            sql.AppendLine("VALUES (@poNum, @comName, @orderDate, @totalAmt, @add,@status)");
            sql.AppendLine(" ");

            SqlConnection conn = dbConn.GetConnection();
            conn.Open();
            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@poNum", poNum);
                sqlCmd.Parameters.AddWithValue("@comName", comName);
                sqlCmd.Parameters.AddWithValue("@orderDate", orderDate);
                sqlCmd.Parameters.AddWithValue("@totalAmt", totalAmt);
                sqlCmd.Parameters.AddWithValue("@add", add);
                sqlCmd.Parameters.AddWithValue("@status", stat);

                inserting = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return inserting;
        }
    }
}