﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thebigfour.BLL;

namespace thebigfour
{
    public partial class viewPO : System.Web.UI.Page
    {
        //  SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\\thebigfour.mdf; Integrated Security = True");

        protected void Page_Load(object sender, EventArgs e)
        {
            string POId = Request.QueryString["POId"].ToString();
            //  int  prodID = int.Parse(Session["ProdID"].ToString());
            BindOrderDetails(Convert.ToInt32(POId));
            lblTotal.Text = CalculateTotal().ToString();
            lblPONum.Text = POId;
            // bindImage(prodID);

        }


        private void BindOrderDetails(int PONum)
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            DataSet ds;
            ds = po.GetOrderDetails(PONum);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        private void bind()
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BllProducts p = new BllProducts();
            Panel1.Visible = true;
            GridView1.Visible = true;
            lblProdID.Text = GridView1.SelectedRow.Cells[0].Text;
            lblDesc.Text = GridView1.SelectedRow.Cells[1].Text;
            lblQty.Text = GridView1.SelectedRow.Cells[2].Text;
            lblPrice.Text = GridView1.SelectedRow.Cells[3].Text;
            Image2.ImageUrl = "http://localhost:60522/supplier-images/" +p.GetProductImage(Convert.ToInt32(lblProdID.Text));

        }




        private decimal CalculateTotal()
        {
            decimal sum = 0;
            int q;
            decimal p;
            decimal totalAmt;
            foreach (GridViewRow row in GridView1.Rows)
            {
                q = Convert.ToInt32(row.Cells[2].Text);
                p = Convert.ToDecimal(row.Cells[3].Text);
                totalAmt = q * p;
                sum = sum + totalAmt;
            }


            return sum;
        }

        protected void createDo_Click(object sender, EventArgs e)
        {
            BllDeliveryOrders d = new BllDeliveryOrders();
            int poNum = Convert.ToInt32(lblPONum.Text);
            int qty = Convert.ToInt32(lblQty.Text);
            //int prodID = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
            //string prodDesc = GridView1.SelectedRow.Cells[1].Text;
            //int qty = Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text);
            //string status = "Processing";
            DateTime time = DateTime.Now;              // Use current time
            string format = "yyyy-MM-dd hh:mm tt";
            string date = time.ToString(format);
            int result = 0;
            result = d.DeliveryInsert(50.00M, "Processing", poNum, date, "Standard" , lblDesc.Text, qty, "boxwear", Convert.ToDecimal(lblTotal.Text));

            if (result == 1)
            {

                BllPurchaseOrders po = new BllPurchaseOrders();
                po.updatePOStatus(poNum);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                        "alert('Insert successful'); window.location='" +
                        Request.ApplicationPath + "pendingpurchaseorders.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
                        "alert('Insert unsuccessful'); window.location='" +
                        Request.ApplicationPath + "pendingpurchaseorders.aspx';", true);
            }



            ////invoce
            //int result = 0;
            //int poNum = Convert.ToInt32(lblPONum.Text);
            //Bllinvoice a = new Bllinvoice();
            //string status = "Processing";
            //DateTime myDateTime = DateTime.Now;
            //string date = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //result = a.insertInvoice(date, Convert.ToDecimal(lblTotal.Text), status, poNum);

            //if (result == 1)
            //{

            //    BllPurchaseOrders po = new BllPurchaseOrders();
            //    po.updatePOStatus(poNum);
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
            //            "alert('Insert successful'); window.location='" +
            //            Request.ApplicationPath + "pendingpurchaseorders.aspx';", true);
            //}else
            //{
            //    ScriptManager.RegisterStartupScript(this, this.GetType(), "redirect",
            //            "alert('Insert unsuccessful'); window.location='" +
            //            Request.ApplicationPath + "pendingpurchaseorders.aspx';", true);
            //}
        }


        //protected void btnCO_Click(object sender, EventArgs e)
        //{
        //    int result = 0;
        //    BllCustomerOrders co = new BllCustomerOrders();
        //    string date = System.DateTime.Now.ToShortDateString();
        //    int poNum = Convert.ToInt32(lblPONum.Text);
        //    string comName = "BoxWear";
        //    DateTime currentdate = Convert.ToDateTime(date);
        //    decimal totalAmount = Convert.ToDecimal(lblTotal.Text);
        //    string addr = "564123";
        //    string stat = "Processsing";
        //    co..InsertCO(poNum, comName, date, totalAmount, addr, stat);
        //}

















    }
}