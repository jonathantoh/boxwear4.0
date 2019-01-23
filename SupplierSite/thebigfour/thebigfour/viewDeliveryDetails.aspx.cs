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
    public partial class viewDeliveryDetails : System.Web.UI.Page
    {
        private String errMsg;
        String connString = ConfigurationManager.ConnectionStrings["thebigfour"].ConnectionString;

        DalDbConn dbConn = new DalDbConn();
        protected void Page_Load(object sender, EventArgs e)
        {

            string id1 = Session["id"].ToString();

            if (id1 != null)
            {
                int id = Convert.ToInt32(Session["id"].ToString());
                BllDeliveryOrders myCat = new BllDeliveryOrders();
                DataSet ds;
                ds = myCat.GetDeliveryDetailsByID(id);
                gvDelivery.DataSource = ds;
                gvDelivery.DataBind();

                int rec = ds.Tables["Table"].Rows.Count;

                DataRow row = ds.Tables["Table"].Rows[0];
                string trackingid = row["trackingID"].ToString();
                string weight = row["weight"].ToString();
                string deliverystatus = row["deliveryStatus"].ToString();
                string type = row["deliveryType"].ToString();
                string value = row["TotalValue"].ToString();
                string poid = row["PoID"].ToString();
                string invoiceid = row["InvoiceID"].ToString();



                //string trackingid = ds.Tables[0].Rows[0]["trackingID"].ToString();
                //string weight = ds.Tables[0].Rows[0]["weight"].ToString();
                //string deliverystatus = ds.Tables[0].Rows[0]["deliveryStatus"].ToString();

                trackingidlbl.Text = trackingid;
                weightlbl.Text = weight + " KG";
                statuslbl.Text = deliverystatus;
                deliveryTypelbl.Text = type;
                valuelbl.Text = value;
                poidlbl.Text = poid;
                inidlbl.Text = invoiceid;

                string status = statuslbl.Text;
                string inid = inidlbl.Text;


                if (invoiceid == null || invoiceid == "")
                {
                    createInvoice.Visible = true;
                }
                else
                {
                    createInvoice.Attributes.Add("disabled", "disabled");
                    //createInvoice.Visible = false;
                }
                if (status != "Delivered")
                {
                    createInvoice.Attributes.Add("disabled", "disabled");

                    //createInvoice.Visible = false;


                }
                if (invoiceid == null || invoiceid == "")
                {
                    viewinvoice.Visible = false;
                }

            }
        }

        protected void createInvoice_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["id"].ToString());

            //invoice
            int result = 0;
            int poNum = Convert.ToInt32(poidlbl.Text);
            Bllinvoice a = new Bllinvoice();
            string status = "Unpaid";
            //DateTime myDateTime = DateTime.Now;
            //DateTime date = DateTime.Now.ToString("dd.MM.yyy");
            DateTime endDate = DateTime.Now.AddMonths(1);
            string duedate = endDate.ToString();

            result = a.insertInvoice(DateTime.Now, Convert.ToDecimal(valuelbl.Text), status, poNum, id, endDate);

            if (result == 1)
            {

                

                //insert inner join here to get invoiceID
                DataSet ds;
                ds= GetInvoiceByID(id);
                int rec = ds.Tables["Table"].Rows.Count;

                DataRow row = ds.Tables["Table"].Rows[0];
                int inid = Convert.ToInt32(row["InvoiceID"].ToString());

                updateDeliveryInvoice(id, inid);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                        "alert('Insert successful'); window.location='" +
                        Request.ApplicationPath + "ViewDeliveryDetails.aspx';", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                        "alert('Insert unsuccessful'); window.location='" +
                        Request.ApplicationPath + "ViewDeliveryDetails.aspx';", true);
            }
        }


            public DataSet GetInvoiceByID(int trackingID)

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
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ProgramData;
        }

        protected void gvDelivery_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        protected void viewinvoice_Click(object sender, EventArgs e)
        {
            string id = inidlbl.Text;
            Session["invoiceid"] = id;



            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Response.Redirect("invoiceReview.aspx");
        }
    }
}