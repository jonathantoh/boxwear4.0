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
    public partial class invoiceReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Session["invoiceid"].ToString();
            int id2 = Convert.ToInt32(Session["invoiceid"].ToString());
            Bllinvoice myCat = new Bllinvoice();
            DataSet ds;
            ds = myCat.GetInvoiceByID(id2);

            string PoID = ds.Tables[0].Rows[0]["PoID"].ToString();
            BindOrderDetails(Convert.ToInt32(PoID));

            BindPOList();

            
        }

        private void BindOrderDetails(int PONum)
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            DataSet ds;
            ds = po.GetOrderDetails(PONum);
            gvPurchase.DataSource = ds;
            gvPurchase.DataBind();
        }

        private void BindPOList()
        {
            int id = Convert.ToInt32(Session["invoiceid"].ToString());
            Bllinvoice myCat = new Bllinvoice();
            DataSet ds;
            ds = myCat.GetInvoiceByID(id);

            int rec = ds.Tables["Table"].Rows.Count;

            DataRow row = ds.Tables["Table"].Rows[0];
            string InvoiceAmt = row["InvoiceAmt"].ToString();
            string InvoiceID = row["InvoiceID"].ToString();
            string InvoiceDate = row["InvoiceDate"].ToString();
            string InvoiceStatus = row["InvoiceStatus"].ToString();
            string PoID = row["PoID"].ToString();
            string due = row["invoiceDue"].ToString();
            string paymentDate = row["paymentDate"].ToString();
            string paymentMadeBy = row["paymentMadeBy"].ToString();



            status_lbl.Text = InvoiceStatus;
            date_lbl.Text = InvoiceDate;
            lbl_TotalPrice.Text = InvoiceAmt;
            Label1.Text = InvoiceID;
            ordernotxt.Text = InvoiceID;
            duelbl.Text = due;
            paymentdatelbl.Text = paymentDate;
            paymentmadebylbl.Text = paymentMadeBy;
            //isssue above. cant myCat.GetInvoiceByID(id);

            if (InvoiceStatus == "Paid")
            {
                paybtn.Visible = false;
            }
        }

        protected void paybtn_Click(object sender, EventArgs e)
        {
            string id = ordernotxt.Text;
            Session["invoiceid"] = id;



            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Response.Redirect("payment.aspx");
        }
    }
}