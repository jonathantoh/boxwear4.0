﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace boxwear
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetChartData();
        }

        private void GetChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["boxwear"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Command to retrieve Students data from Students table
                SqlCommand cmd = new
                    SqlCommand("Select PoDate,PoTotalAmt FROM PurchaseOrders", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                // Retrieve the Series to which we want to add DataPoints
                Series series = Chart1.Series["Series1"];
                // Loop thru each Student record
                while (rdr.Read())
                {
                    // Add X and Y values using AddXY() method
                    series.Points.AddXY(rdr["PoDate"].ToString(),
                        rdr["PoTotalAmt"]);
                }
            }
        }


    }
}