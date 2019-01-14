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
using thebigfour.BLL;

namespace thebigfour
{
    public partial class pendingpurchaseorders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BllProducts p = new BllProducts();
                BindCustomerOrder();
                lbl_num.Text = gvPurchase.Rows.Count.ToString() + " "+"PUCRHASE ORDERS ";
                // lbl_amt.Text = "$" + " " +CalculateTotal().ToString() + " " + "on hand";
                lbl_amt.Text = "Processing, New, Delivered";
                lbl_company.Text = "BoxWear";
            }
        }

        private void BindCustomerOrder()
        {
            BllPurchaseOrders myCat = new BllPurchaseOrders();
            DataSet ds;
            ds = myCat.GetCO();
            gvPurchase.DataSource = ds;
            gvPurchase.DataBind();

        }


        

        //private decimal CalculateTotal()
        //{
        //    decimal sum = 0;
        //    decimal totalAmt;
        //    foreach (GridViewRow row in gvPurchase.Rows)
        //    {
        //        totalAmt = Convert.ToDecimal(row.Cells[2].Text);
        //        sum = sum + totalAmt;
        //    }

        //    return sum;

        //}

        protected void gvPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvPurchase.SelectedRow;


            string POId = row.Cells[0].Text;
           // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Response.Redirect("viewPO.aspx?POId=" + POId );
        }
    }
}