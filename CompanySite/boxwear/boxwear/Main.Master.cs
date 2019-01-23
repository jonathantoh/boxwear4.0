using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//namespace BoxWear
//{
public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] != null)
            {

                string admin = Session["admin"].ToString();
                string fname = getUser(admin);
                welcome.Text = "Welcome, " + fname;

                lbtnLogout.Visible = true;
            }
            else if (Session["admin"] == null)
            {
                lbtnLogout.Visible = false;
            }
        


        }
    protected void lbtnLogout_Click(object sender, EventArgs e)
    {

        Session.Remove("admin");

        Response.Redirect("adminLogin.aspx");

    }

    public string getUser(string email)
    {
        string _connStr = ConfigurationManager.ConnectionStrings["boxwear"].ConnectionString;
        string fn ="";
        SqlConnection conn = new SqlConnection(_connStr);
        conn.Open();
        string query = "select * from admin where username='" + email + "'";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        da.SelectCommand = cmd;

        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            fn = ds.Tables[0].Rows[0]["firstName"].ToString();
            //LName = ds.Tables[0].Rows[0]["custLName"].ToString();
            //email = ds.Tables[0].Rows[0]["custEmail"].ToString();
            //Hp = ds.Tables[0].Rows[0]["custContact"].ToString();

            ////address
            //Address = ds.Tables[0].Rows[0]["custAddress"].ToString();
            //Postal = ds.Tables[0].Rows[0]["postal"].ToString();
            //City = ds.Tables[0].Rows[0]["city"].ToString();
            //Country = ds.Tables[0].Rows[0]["country"].ToString();

            ////Points
            //RewardPoints = (int)ds.Tables[0].Rows[0]["rewardPoints"];

            ////password
            //Password = ds.Tables[0].Rows[0]["custPassword"].ToString();

            //custDetails = new Customer(FName, LName, email, Hp, Address, Postal, City, Country, RewardPoints, Password);
        }
        

        conn.Close();
        dr.Close();
        dr.Dispose();

        return fn;
    }
}
//}