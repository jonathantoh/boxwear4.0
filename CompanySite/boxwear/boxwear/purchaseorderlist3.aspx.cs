using boxwear.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class purchaseorderlist3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPOList();
                GetChartData();
            }
       
        }

        private void BindPOList()
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            DataSet ds;
            ds = po.GetProductCatalogue();
            gvPurchase.DataSource = ds;
            gvPurchase.DataBind();
        }

        private void GetChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["boxwear"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Command to retrieve Students data from Students table
                SqlCommand cmd = new SqlCommand("Select ProductName, ProductQty FROM ProductCatalogue", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                // Retrieve the Series to which we want to add DataPoints
                Series series = Chart1.Series["Series1"];
                // Loop thru each Student record
                while (rdr.Read())
                {
                    // Add X and Y values using AddXY() method
                    series.Points.AddXY(rdr["ProductName"].ToString(),
                        rdr["ProductQty"]);
                }
            }
        }
       

        protected void btnPO_Click(object sender, EventArgs e)
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            string productID = "";
            string desc = "";
            string quantity = "";
            string unitPrice = "";
            //   int poNum = po.GetPoID();
            CheckBox cb = new CheckBox();
            foreach (GridViewRow row in gvPurchase.Rows)
            {
                cb = (CheckBox)row.FindControl("CheckBox1");
                if (!cb.Checked)
                    continue;

                if (productID == "")
                {
                    productID += row.Cells[0].Text;
                    desc += row.Cells[1].Text;
                    quantity += row.Cells[2].Text;
                    unitPrice += row.Cells[3].Text;
                    continue;
                }

                productID += "," + row.Cells[0].Text;
                desc += "," + row.Cells[1].Text;
                quantity += "," + row.Cells[2].Text;
                unitPrice += "," + row.Cells[3].Text;
            }

            po.CreatePOI(productID, desc, quantity, unitPrice,"New");



        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            int index = 0;
            for (int i = 0; i < gvPurchase.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)gvPurchase.Rows[i].FindControl("CheckBox1");
                if (!cb.Checked)
                    continue;

                index = i;
            }
        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductCatalogue.aspx");
        }
    }
}