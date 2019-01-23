using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using judovan.BLL;
using System.Data;

namespace judovan
{
    public partial class deliverydetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Bind();
            }
        }

        private void Bind()
        {
            BLLDelivery myCat = new BLLDelivery();
            DataSet ds;
            ds = myCat.GetDelivery();
            gvDelivery.DataSource = ds;
            gvDelivery.DataBind();

        }

        protected void gvPurchase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvDelivery.SelectedRow;


            string id = row.Cells[0].Text;
            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            string trackingID = row.Cells[0].Text;
            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Session["id"] = trackingID;
            Response.Redirect("deliveryMoreDetails.aspx");

        }

    }
}