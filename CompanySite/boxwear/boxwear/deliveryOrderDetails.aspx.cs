using boxwear.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class deliveryOrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["id"].ToString());
            BllDelivery myCat = new BllDelivery();
            DataSet ds;
            ds = myCat.GetDeliveryDetailsByID(id);

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
            invoicelbl.Text = invoiceid;


            if (invoiceid == null || invoiceid == "")
            {
                viewinvoice.Visible = false;
            }
            else
            {
                viewinvoice.Visible = true;
            }
        }

        protected void viewinvoice_Click(object sender, EventArgs e)
        {
            string id = invoicelbl.Text;
            Session["invoiceid"] = id;



            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Response.Redirect("invoiceReview.aspx");
        }
    }
}