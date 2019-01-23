//using judovan.SvcRefTheBigFour;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Text;
using judovan.SvcRefTheBigFour;

namespace judovan.DAL
{
    public class DalDelivery
    {
        private String errMsg;

        DalDbConn dbCon = new DalDbConn();

        //public void createDelivery(decimal weight, string deliveryStatus, int PoID, int invoiceID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty)
        //{
        //    int result = 0;
        //    string strConnString = ConfigurationManager.ConnectionStrings["judovan"].ConnectionString;
        //    SqlConnection myConnect = new SqlConnection(strConnString);
        //    string strCommand = "Insert INTO Delivery (weight, deliveryStatus, PoID, InvoiceID, dateRegistered, deliveryType, ProductDesc, ProductQty) Values(@weight, @deliveryStatus, @PoID, @invoiceID, @dateRegistered, @deliveryType, @ProductDesc, @ProductQty)";
        //    SqlCommand cmd = new SqlCommand(strCommand, myConnect);
        //    cmd.Parameters.AddWithValue("@weight", weight);
        //    cmd.Parameters.AddWithValue("@deliveryStatus", deliveryStatus);
        //    cmd.Parameters.AddWithValue("@PoID", PoID);
        //    cmd.Parameters.AddWithValue("@invoiceID", invoiceID);
        //    cmd.Parameters.AddWithValue("@dateRegistered", dateRegistered);
        //    cmd.Parameters.AddWithValue("@deliveryType", deliveryType);
        //    cmd.Parameters.AddWithValue("@ProductDesc", ProductDesc);
        //    cmd.Parameters.AddWithValue("@ProductQty", ProductQty);

        //    myConnect.Open();
        //    result += cmd.ExecuteNonQuery();
        //    myConnect.Close();
        //    //return result;
        //}


        //public DataSet GetAllDelivery()
        //{
        //    StringBuilder sql;
        //    SqlDataAdapter da;
        //    DataSet ProgramData;

        //    SqlConnection conn = dbCon.GetConnection();

        //    ProgramData = new DataSet();
        //    sql = new StringBuilder();
        //    sql.AppendLine("SELECT * FROM Delivery");

        //    try
        //    {
        //        da = new SqlDataAdapter(sql.ToString(), conn);
        //        da.Fill(ProgramData);
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return ProgramData;
        //}

        //public DataSet getDelivery(int trackingID)
        //{

        //    StringBuilder sql;
        //    SqlDataAdapter da;
        //    DataSet ProgramData;

        //    SqlConnection conn = dbCon.GetConnection();

        //    ProgramData = new DataSet();
        //    sql = new StringBuilder();
        //    sql.AppendLine("Select *");
        //    sql.AppendLine("From Delivery");
        //    sql.AppendLine("Where trackingID=@trackingID");

        //    try
        //    {
        //        da = new SqlDataAdapter(sql.ToString(), conn);
        //        da.SelectCommand.Parameters.AddWithValue("trackingID", trackingID);
        //        da.Fill(ProgramData);
        //    }
        //    catch (Exception ex)
        //    {
        //        errMsg = ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return ProgramData;

        //}

        public DataSet GetDelivery()
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetAll();
        }

        public DataSet GetDeliveryDetailsByID(int id)
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetDeliveryDetailsByID(id);
        }

        public DataSet UpdateDeliveryInvoice(int id, int invoiceID)
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.updateDeliveryInvoice(id, invoiceID);
        }
    }
}