using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            int result = 0;


            result = UserLogin(txtusername.Text, txtpassword.Text);

            //int result = 0;
            //Customer cust = new Customer(txtusername.Text, txtpassword.Text);
            //result = cust.UserLogin();

            if (result > 0)
            {
                Session["admin"] = txtusername.Text;
                Response.Redirect("~/dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login NOT successful');</script>");
            }
        }

        private int UserLogin(string text1, string text2)
        {
            string _connStr = ConfigurationManager.ConnectionStrings["boxwear"].ConnectionString;
            SqlConnection conn = new SqlConnection(_connStr);
            conn.Open();
            string query = "SELECT count(*) FROM admin where username='" + text1 + "' and password='" + text2 + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            string output = cmd.ExecuteScalar().ToString();

            if (output == "1")
            {
                return 1;
            }
            else
            {
                return 0;
            }
    }
    }
}