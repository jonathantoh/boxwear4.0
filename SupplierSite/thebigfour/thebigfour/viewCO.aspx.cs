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
    public partial class viewCO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string CONum = Request.QueryString["CONum"].ToString();
            BindOrderDetails(Convert.ToInt32(CONum));

        }

        private void BindOrderDetails(int coNum)
        {
            BllPurchaseOrders po = new BllPurchaseOrders();
            DataSet ds;
            ds = po.GetOrderDetails(coNum);
            gvCustOrder.DataSource = ds;
            gvCustOrder.DataBind();
        }


    }
}