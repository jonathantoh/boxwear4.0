using boxwear.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class purchaseorderlist2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindPOList();
        }

        private void BindPOList()
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            DataSet ds;
            ds = po.GetPOList();
            gvPurchase.DataSource = ds;
            gvPurchase.DataBind();
        }

        private void BindPOFiltered(string status)
        {
            BllPurchaseOrders myCat = new BllPurchaseOrders();
            DataSet ds;
            ds = myCat.GetPOListFiltered(status);
            gvPurchase.DataSource = ds;
            gvPurchase.DataBind();
        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlStatus.SelectedValue == "All")
            {
                BindPOList();
            }
            else
            {
                string Status = ddlStatus.SelectedValue.ToString();
                BindPOFiltered(Status);
            }
        }

        protected void btnNum_Click(object sender, EventArgs e)
        {
            BllPurchaseOrders po = new BllPurchaseOrders();

            
        }
    }
}