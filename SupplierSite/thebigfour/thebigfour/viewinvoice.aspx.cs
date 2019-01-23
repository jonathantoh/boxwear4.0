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
    public partial class viewinvoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindPOList();
        }
        private void BindPOList()
        {
            Bllinvoice myCat = new Bllinvoice();
            DataSet ds;
            ds = myCat.GetAllInvoice();
            gvInvoice.DataSource = ds;
            gvInvoice.DataBind();
        }

        protected void gvInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvInvoice.SelectedRow;
            string id = row.Cells[0].Text;
            Session["invoiceid"] = id;


            
            // int ProdID = Convert.ToInt32(row.Cells[1].Text);

            Response.Redirect("invoiceReview.aspx");
        }
    }
}