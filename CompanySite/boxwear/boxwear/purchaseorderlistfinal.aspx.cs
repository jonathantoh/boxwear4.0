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
    public partial class purchaseorderlistfinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindPOList();
        }


        private void BindPOList()
        {
            BllPurchaseOrders myCat = new BllPurchaseOrders();
            DataSet ds;
            ds = myCat.GetPOList();
            gvOrder.DataSource = ds;
            gvOrder.DataBind();
        }

    }
}