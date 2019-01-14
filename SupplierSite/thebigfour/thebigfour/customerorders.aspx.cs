using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using thebigfour.BLL;

namespace thebigfour
{
    public partial class customerorders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BindAllCO();
            }
        }

        protected void gvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvCustomer.SelectedRow;
            string CONum = row.Cells[0].Text;
            Response.Redirect("viewCO.aspx?CONum=" + CONum);
        }

        private void BindAllCO()
        {
            BllCustomerOrders bll = new BllCustomerOrders();
            DataSet ds;
            ds = bll.GetAllCO();
            gvCustomer.DataSource = ds;
            gvCustomer.DataBind();
        }
    }
}