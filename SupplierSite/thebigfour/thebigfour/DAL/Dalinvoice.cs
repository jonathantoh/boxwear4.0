using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace thebigfour.DAL
{
    public class Dalinvoice
    {
        private String errMsg;
        String connString = ConfigurationManager.ConnectionStrings["thebigfour"].ConnectionString;

        DalDbConn dbConn = new DalDbConn();
        public DataSet GetAllInvoice()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet invoicedata;

            SqlConnection conn = dbConn.GetConnection();
            invoicedata = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * ");
            sql.AppendLine("FROM Invoice");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(invoicedata);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return invoicedata;
        }

        public DataSet GetInvoiceByID(int InvoiceID)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet invoicedata;

            SqlConnection conn = dbConn.GetConnection();
            invoicedata = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * ");
            sql.AppendLine("FROM Invoice WHERE InvoiceID=@InvoiceID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("InvoiceID", InvoiceID);
                da.Fill(invoicedata);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return invoicedata;
        }

        public DataSet GetInvoiceByTrackingID(int trackingID)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet invoicedata;

            SqlConnection conn = dbConn.GetConnection();
            invoicedata = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * ");
            sql.AppendLine("FROM Invoice WHERE trackingID=@trackingID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("trackingID", trackingID);
                da.Fill(invoicedata);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return invoicedata;
        }


        public DataSet updateInvoicePayment(int InvoiceID, string ccNo, string ccv, string expDate, string status, DateTime paymentDate, string paymentMadeBy)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("UPDATE Invoice");
            sql.AppendLine("SET ccNo = @ccNo");
            sql.AppendLine(",ccv= @ccv");
            sql.AppendLine(", expDate = @expDate");
            sql.AppendLine(", paymentDate = @paymentDate");
            sql.AppendLine(", paymentMadeBy = @paymentMadeBy");
            sql.AppendLine(", InvoiceStatus = @InvoiceStatus");

            sql.AppendLine("WHERE InvoiceID = @InvoiceID");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("InvoiceID", InvoiceID);
                da.SelectCommand.Parameters.AddWithValue("ccNo", ccNo);
                da.SelectCommand.Parameters.AddWithValue("ccv", ccv);
                da.SelectCommand.Parameters.AddWithValue("expDate", expDate);
                da.SelectCommand.Parameters.AddWithValue("InvoiceStatus", status);
                da.SelectCommand.Parameters.AddWithValue("paymentDate", paymentDate);
                da.SelectCommand.Parameters.AddWithValue("paymentMadeBy", paymentMadeBy);


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

        public int CreatePOI(DateTime InvoiceDate, decimal InvoiceAmt, string InvoiceStatus, int PoID, int trackingID, DateTime endDate)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();

            sql.AppendLine("INSERT INTO Invoice(InvoiceDate, InvoiceAmt, InvoiceStatus, PoID, trackingID, invoiceDue)");
            sql.AppendLine("VALUES (@InvoiceDate, @InvoiceAmt, @InvoiceStatus, @PoID, @trackingID, @invoiceDue)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
                cmd.Parameters.AddWithValue("@InvoiceAmt", InvoiceAmt);
                cmd.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);
                cmd.Parameters.AddWithValue("@PoID", PoID);
                cmd.Parameters.AddWithValue("@trackingID", trackingID);
                cmd.Parameters.AddWithValue("@invoiceDue", endDate);



                //cmd.Parameters.AddWithValue("@PONum", PONum);

                // cmd.Parameters.AddWithValue("@PoID", PoID);
                //cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return result;

        }



        //public int insertInvoice(string InvoiceDate, decimal InvoiceAmt, string InvoiceStatus, int PoID)
        //{
        //    //StringBuilder sql;
        //    //SqlCommand sqlCmd;
        //    //int inserting;

        //    //inserting = 0;

        //    //sql = new StringBuilder();

        //    //sql.AppendLine("INSERT INTO Invoice (InvoiceDate, InvoiceAmt, InvoiceStatus, PoID)");
        //    //sql.AppendLine(" ");
        //    //sql.AppendLine("VALUES (@InvoiceDate, @InvoiceAmt, @InvoiceStatus, @PoID)");
        //    //sql.AppendLine(" ");

        //    //SqlConnection conn = dbConn.GetConnection();
        //    //conn.Open();
        //    //try
        //    //{
        //    //    sqlCmd = new SqlCommand(sql.ToString(), conn);
        //    //    sqlCmd.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
        //    //    sqlCmd.Parameters.AddWithValue("@InvoiceAmt", InvoiceAmt);
        //    //    sqlCmd.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);
        //    //    sqlCmd.Parameters.AddWithValue("@PoID", PoID);

        //    //    inserting = sqlCmd.ExecuteNonQuery();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    errMsg = ex.Message;
        //    //}
        //    //finally
        //    //{
        //    //    conn.Close();
        //    //}

        //    //return inserting;

        //    int result = 0;
        //    string queryStr = "INSERT INTO Invoice (InvoiceDate, InvoiceAmt, InvoiceStatus, PoID)" + "VALUES (@InvoiceDate, @InvoiceAmt, @InvoiceStatus, @PoID)";
        //    //+ "values (@Product_ID, @Product_Name, @Product_Desc, @Unit_Price,@Product_Image,@Stock_Level)";

        //    try
        //    {
        //        SqlConnection conn = new SqlConnection(connString);
        //        SqlCommand sqlCmd = new SqlCommand(queryStr, conn);
        //        sqlCmd.Parameters.AddWithValue("@InvoiceDate", InvoiceDate);
        //        sqlCmd.Parameters.AddWithValue("@InvoiceAmt", InvoiceAmt);
        //        sqlCmd.Parameters.AddWithValue("@InvoiceStatus", InvoiceStatus);
        //        sqlCmd.Parameters.AddWithValue("@PoID", PoID);
        //        conn.Open();
        //        result += sqlCmd.ExecuteNonQuery(); // Returns no. of rows affected. Must be > 0
        //        conn.Close();

        //        return result;
        //    }
        //    catch (Exception ex)
        //    {
        //        return 0;
        //    }
        //}
    }
}