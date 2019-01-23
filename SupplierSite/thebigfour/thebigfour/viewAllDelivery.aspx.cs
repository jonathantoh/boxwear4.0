using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thebigfour.BLL;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using thebigfour.DAL;

namespace thebigfour
{
    public partial class viewAllDelivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Bind();
                
            }
        }

        private void Bind()
        {
            BllDeliveryOrders myCat = new BllDeliveryOrders();
            DataSet ds;
            ds = myCat.GetAll();
            gvDelivery.DataSource = ds;
            gvDelivery.DataBind();

        }

        protected void gvPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvDelivery.SelectedRow;


            string id = row.Cells[0].Text;
            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            string trackingID = row.Cells[0].Text;
            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Session["id"] = trackingID;
            Response.Redirect("viewDeliveryDetails.aspx");

        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.SelectedValue == "All")
            {
                Bind();
            }
            else
            {
                string Status = ddlStatus.SelectedValue.ToString();
                BindPOFiltered(Status);
            }
        }

        private void BindPOFiltered(string status)
        {

            DataSet ds;
            ds = GetPOListFiltered(status);
            gvDelivery.DataSource = ds;
            gvDelivery.DataBind();
        }

        public DataSet GetPOListFiltered(string status)
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            DalDbConn dbConn = new DalDbConn();

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM Delivery");
            sql.AppendLine("WHERE deliveryStatus = @PS");
            sql.AppendLine("ORDER BY trackingID DESC");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("PS", status);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                string errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return ProgramData;
        }
    }
}