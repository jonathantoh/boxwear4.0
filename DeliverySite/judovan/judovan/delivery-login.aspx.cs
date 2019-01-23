using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace judovan
{
    public partial class delivery_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["deliveryadmin"] != null)
            {
                Response.Redirect("~/delivery-dashboard.aspx");
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //bool result;
            //if (txtusername.Text == "supportjudo@gmail.com" && txtpassword.Text == "123")
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}

            //if (result == true)
            //{
            //    Session["deliveryadmin"] = txtusername.Text;
            //    Response.Redirect("delivery-dashboard.aspx");
            //}
            //else
            //{
            //    lblerror.Text = "Incorrect details";
            //}
        }
    }
}