using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace judovan
{
    public partial class delivery : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["deliveryadmin"] != null)
            {
                //Customer custDetails = null;
                //Customer cust = new Customer();
                //string custEmail = Session["admin"].ToString();
                //custDetails = cust.getUser(custEmail);
                welcome.Text = "Welcome, Admin Judo";

                lbtnLogout.Visible = true;
            }
            else if (Session["deliveryadmin"] == null)
            {
                lbtnLogout.Visible = false;
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("deliveryadmin");
            Response.Redirect("delivery-login.aspx");
        }
    }
}