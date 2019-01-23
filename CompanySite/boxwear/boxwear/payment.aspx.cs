using boxwear.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["invoiceid"]);
        }

        protected void paynow_btn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["invoiceid"]);

            string creditc = ccNo.Text;
            string cardType = CreditCardUtility.GetTypeName(creditc);
            cardtype.Text = cardType;

            bool exp = isValid(expDate.Text);
            //if (exp == false)
            //{

            //}


            if (cardType == "Unknown" || exp == false)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                            "alert('Credit card is INVALID'); window.location='" +
                            Request.ApplicationPath + "payment.aspx';", true);
            }
            else
            {
                //need to login to work
                string paymentMadeBy = Session["user"].ToString();
                Bllinvoice myCat = new Bllinvoice();
                myCat.UpdateInvoicePayment(id, ccNo.Text, ccv.Text, expDate.Text, "Paid", DateTime.Now, paymentMadeBy);

                string id1 = (Session["invoiceid"]).ToString();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                            "alert('Payment Successful'); window.location='" +
                            Request.ApplicationPath + "invoiceReview.aspx';", true);

            }

        }

        bool isValid(string dateString)
        {
            DateTime dateValue;


            if (DateTime.TryParse(dateString, out dateValue))
                if (dateValue < DateTime.Now)
                    return false;
                else
                    return true;
            else
                return false;
        }
    }
}