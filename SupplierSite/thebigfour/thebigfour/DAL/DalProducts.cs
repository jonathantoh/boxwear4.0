using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace thebigfour.DAL
{
    public class DalProducts
    {
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        private int prodID;
        private string image;
        string connStr = ConfigurationManager.ConnectionStrings["thebigfour"].ConnectionString;



        public DalProducts(int prodID)
        {
            this.prodID = prodID;
          
        }

        public DalProducts()
        {

        }
        public DataSet GetAllProducts()
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT * FROM Products");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.Fill(ProgramData);
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            return ProgramData;
        }


        public DalProducts GetProductImage(int prodID)
        {
            DalProducts prodDetail = null;
            string  prodImage;
           
            string queryStr = "SELECT ProductImage FROM Products WHERE ProductID = @ProdID";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@ProdID", prodID);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //Check if there are any resultsets
            if (dr.Read())
            {
                prodImage = dr["ProductImage"].ToString();
                prodDetail = new DalProducts(prodID);
            }
           
            conn.Close();
            dr.Close();
            dr.Dispose();
            return prodDetail;
        }

      

    }
}