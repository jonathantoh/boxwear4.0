﻿using boxwear.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class ProductCatalogue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnReturn.Visible = true;
            BindProductCatalogue();

        }

        private void BindProductCatalogue()
        {
            BllProducts myProd = new BllProducts();
            DataSet ds;
            ds = myProd.GetAllProducts();
            gvProduct.DataSource = ds;
            gvProduct.DataBind();
        }


        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            gvProduct.Visible = false;

          
            lblProdId.Text = gvProduct.SelectedRow.Cells[0].Text;
            lblName.Text = gvProduct.SelectedRow.Cells[1].Text;
            lblDesc.Text = gvProduct.SelectedRow.Cells[3].Text;
            lblPrice.Text = gvProduct.SelectedRow.Cells[4].Text;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductCatalogue.aspx");
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
           
            BllPurchaseOrders po = new BllPurchaseOrders();
            int prodID = Convert.ToInt32(lblProdId.Text);
            int quantity = Convert.ToInt32(tbQuantity.Text);
            decimal amt = 0;
            decimal unitPrice = Convert.ToDecimal(lblPrice.Text);
            decimal totalPrice = quantity * unitPrice;
            po.CreatePOI(prodID,lblName.Text,quantity,unitPrice,totalPrice);

            // need to insert into purchaseOrders 
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            po.CreatePO(date, "Pending", totalPrice, "BoxWear", "TheBigFour");

            Response.Redirect("ProductCatalogue.aspx");
        }
    }
}