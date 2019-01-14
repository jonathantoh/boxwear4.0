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
               
                BindCustomerOrder();
                lbl_num.Text = gvPurchase.Rows.Count.ToString() + " "+"PUCRHASE ORDERS ";
             //   lbl_amt.Text = "$" + " " +CalculateTotal().ToString() + " " + "on hand";
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
            int row = gvPurchase.Rows.Count;
            for (int i = 0; i < row; i++)
            {
                string Status = gvPurchase.Rows[i].Cells[3].Text;
                if (Status != "New")
                {
                    gvPurchase.Rows[i].Cells[5].ForeColor = System.Drawing.Color.Crimson;
                    gvPurchase.Rows[i].Cells[5].Enabled = false;
                }
            }

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

        protected void gvPurchase_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Create")
            {
                GridViewRow gvr = (GridViewRow)(((LinkButton)e.CommandSource).NamingContainer);
                int rowIndex = gvr.RowIndex;
                int PoID = Convert.ToInt32(gvPurchase.DataKeys[rowIndex].Values[0]);
                Response.Redirect("createDO.aspx?PoNum=" + PoID);
            }
        }
    }
}