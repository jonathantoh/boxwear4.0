using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace judovan
{
    public partial class CostCalculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            double rate = 1.69;
            double shippingFee = rate * (Convert.ToDouble(weightTxt.Text)*1000/500);

            economyTxt.Text = "$" + shippingFee.ToString();

            expressTxt.Text = "$" + (shippingFee*1.5).ToString();

        }
    }
}