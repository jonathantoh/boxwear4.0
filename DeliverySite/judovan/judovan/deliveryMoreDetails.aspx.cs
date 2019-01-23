using judovan.BLL;
using judovan.SvcRefTheBigFour;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using judovan.SvcRefTheBigFour;
//using Twilio;
//using Twilio.Rest.Api.V2010.Account;
//using Twilio.Types;

namespace judovan
{
    public partial class deliveryMoreDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TextBox1.Text = Session["id"].ToString();

            if(TextBox1.Text != null)
            {
                int id = Convert.ToInt32(Session["id"].ToString());
                BLLDelivery myCat = new BLLDelivery();
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

                //string trackingid = ds.Tables[0].Rows[0]["trackingID"].ToString();
                //string weight = ds.Tables[0].Rows[0]["weight"].ToString();
                //string deliverystatus = ds.Tables[0].Rows[0]["deliveryStatus"].ToString();

                trackingidlbl.Text = trackingid;
                weightlbl.Text = weight + " KG";
                statuslbl.Text = deliverystatus;
                deliveryTypelbl.Text = type;
                valuelbl.Text = "$" + value;
                poidlbl.Text = poid;
            }
        }

        private void BindPOList()
        {
            int id = Convert.ToInt32(Session["id"].ToString());

            BLLDelivery myCat = new BLLDelivery();
            DataSet ds;
            ds = myCat.GetDeliveryDetailsByID(id);
            gvDelivery.DataSource = ds;
            gvDelivery.DataBind();
        }

        protected void search_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["id"].ToString());
            BLLDelivery myCat = new BLLDelivery();
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

            //string trackingid = ds.Tables[0].Rows[0]["trackingID"].ToString();
            //string weight = ds.Tables[0].Rows[0]["weight"].ToString();
            //string deliverystatus = ds.Tables[0].Rows[0]["deliveryStatus"].ToString();

            trackingidlbl.Text = trackingid;
            weightlbl.Text = weight + " KG";
            statuslbl.Text = deliverystatus;
            deliveryTypelbl.Text = type;
            valuelbl.Text = "$" +value;
            poidlbl.Text = poid;

        }

        protected void save_btn_Click(object sender, EventArgs e)
        {

            string result = DropDownList1.SelectedItem.Value;
            string option = DropDownList1.SelectedItem.ToString();

            int id = Convert.ToInt32(trackingidlbl.Text);
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            DataSet ds;
            ds = d.updateDOStatus(id, result);

            if (option == "In Transit")
            {
                //Email mail = new Email("jonathantohjj@gmail.com");
                //mail.CreateTestMessage3("jonathantohjj@gmail.com", "Your BoxWear order #" + id + " has been shipped!",

                //    "<div style='margin: auto; width: 60%; border: 6px solid #000000;padding: 10px;'><span style='font-family:'Open Sans','Helvetica Neue',Helvetica,Arial,sans-serif;;font-size:16px; '>Dear Sir/Mdm" +
                //    ",<br/><br/>A shipment from order #" + id + " is on the way<br/><br/>" +
                //    "<b>ORDER NUMBER: #" + id + "</b><br/><br/><div style='text-align:center'>Hi "  + ", You can track your order with this tracking ID <a href='http://www.boxwear.com'>" + id + "</a> </div>" +
                //    "<br/><br/>You may proceed to login to check your order by clicking on the button below." +
                //    "<br/><table><tr><td style='background-color: #6dc066;border-color: #4c5764;border: 2px solid #45b7af;padding: 10px;text-align: center;'><a href='http://www.boxwear.com'>Click me</a></td></tr></table>" +
                //    "<br/>Regards,<br/>BoxWear</span></div>");
            }
            else if (option == "Delivered")
            {
                ////for testing purposes only (using Jon's phone number)
                //const string accountSid = "AC8ab1573144eef679a9822aeaf910c881";
                //const string authToken = "7e83655c82492197c1b9a75283f95a9c";
                //TwilioClient.Init(accountSid, authToken);

                //MessageResource.Create(
                //    to: new PhoneNumber("+6597264511"),
                //    from: new PhoneNumber("+15403286399"),
                //    body: "Hi, " + custDetails.FName + ". Your BoxWear order #" + orderid + " has been delivered");
                BLLDelivery myCat = new BLLDelivery();
                DataSet ds1;
                ds1 = myCat.GetDeliveryDetailsByID(id);
                gvDelivery.DataSource = ds1;
                gvDelivery.DataBind();

                int rec = ds1.Tables["Table"].Rows.Count;

                DataRow row = ds1.Tables["Table"].Rows[0];
                int trackingid = Convert.ToInt32(row["trackingID"].ToString());
                string weight = row["weight"].ToString();
                string deliverystatus = row["deliveryStatus"].ToString();
                string type = row["deliveryType"].ToString();
                decimal value = Convert.ToDecimal(row["TotalValue"].ToString());
                int poid = Convert.ToInt32(row["PoID"].ToString());

                string status = "Unpaid";
                DateTime endDate = DateTime.Now.AddMonths(1);

                WsTheBigFourClient programSupplierClient;
            programSupplierClient = new WsTheBigFourClient();
            int result1 = programSupplierClient.insertInvoice(DateTime.Now, value, status, poid, trackingid, endDate);
                if (result1 == 1)
                {
                    //get and update delivery (invoice id)

                    WsTheBigFourClient programSupplierClient1;
                    programSupplierClient1 = new WsTheBigFourClient();
                    DataSet ds2;
                    ds2 = programSupplierClient.GetInvoiceByTrackingID(id);
                    int rec2 = ds2.Tables["Table"].Rows.Count;

                    DataRow row2 = ds2.Tables["Table"].Rows[0];
                    int inid = Convert.ToInt32(row2["InvoiceID"].ToString());

                    myCat.UpdateDeliveryInvoice(id, inid);

                    ////insert inner join here to get invoiceID
                    //DataSet ds;
                    //ds = GetInvoiceByID(id);
                    //int rec = ds.Tables["Table"].Rows.Count;

                    //DataRow row = ds.Tables["Table"].Rows[0];
                    //int inid = Convert.ToInt32(row["InvoiceID"].ToString());

                    //updateDeliveryInvoice(id, inid);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                            "alert('Insert successful'); window.location='" +
                            Request.ApplicationPath + "ViewDeliveryDetails.aspx';", true);
                }
                    //Email mail = new Email("jonathantohjj@gmail.com");

                    //        mail.CreateTestMessage3("jonathantohjj@gmail.com", "Your BoxWear order #" + id + " has been delivered!",

                    //            "<div style='margin: auto; width: 60%; border: 6px solid #000000;padding: 10px;'><span style='font-family:'Open Sans','Helvetica Neue',Helvetica,Arial,sans-serif;;font-size:16px; '>Dear Sir/Mdm" +
                    //            ",<br/><br/>Your order #" + id + " has been delivered<br/><br/>" +
                    //            "<b>ORDER NUMBER: #" + id + "</b><br/><br/><div style='text-align:center'>Hi" + ", Thank you for your purchase with BoxWear!</div>" +
                    //            "<br/><br/>You may proceed to login to check your order by clicking on the button below." +
                    //            "<br/><table><tr><td style='background-color: #6dc066;border-color: #4c5764;border: 2px solid #45b7af;padding: 10px;text-align: center;'><a href='http://www.boxwear.com'>Click me</a></td></tr></table>" +
                    //            "<br/>Regards,<br/>BoxWear</span></div>");


                }
            Response.Redirect("deliveryMoreDetails.aspx");

        }



    }
}