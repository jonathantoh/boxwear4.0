using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace boxwear.DAL
{
    public class DalPurchaseOrders
    {
        private int prodID;
        private string prodDesc;
        private int qty;
        private decimal unitPrice;
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        private string msg;
        string connStr = ConfigurationManager.ConnectionStrings["boxwear"].ConnectionString;

        public DataSet GetPOList()
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM PurchaseOrderItems");
            sql.AppendLine("ORDER BY PoID DESC");

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



        public DataSet GetProductCatalogue()
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM ProductCatalogue");

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





        public DataSet GetPOItems()
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM PurchaseOrderItem");
            sql.AppendLine("ORDER BY PoID ");

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






        public DataSet GetPOListFiltered(string status)
        {

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM PurchaseOrders");
            sql.AppendLine("WHERE PoStatus = @PS");
            sql.AppendLine("ORDER BY PoID DESC");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("PS", status);
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

        public int GetPoID()
        {
            int PO;
            SqlConnection conn = dbConn.GetConnection();
            SqlCommand getPO = new SqlCommand("SELECT MAX(PoID) + 1 FROM PurchaseOrderItem ", conn);
            conn.Open();
            PO = Convert.ToInt32(getPO.ExecuteScalar());
            conn.Close();
            return PO;
        }

        public int CreatePOI(string productID, string ProductDesc, string quantity, string unitPrice, string status)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO PurchaseOrderItems(ListOfProductID,ProdDesc,ListOfProductQty, ListOfUnitPrice, PoStatus)");
            sql.AppendLine("VALUES (@productID, @productDesc, @productQty, @UnitPrice, @status)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@productDesc", ProductDesc);
                cmd.Parameters.AddWithValue("@productQty", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@status", status);

                //cmd.Parameters.AddWithValue("@PONum", PONum);

                // cmd.Parameters.AddWithValue("@PoID", PoID);
                //cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return result;

        }




        public int InsertCatalogue(int productID, string name, string ProductDesc, int quantity, decimal unitPrice)
        {
            StringBuilder sql;
            SqlCommand cmd;
            int result;
            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO ProductCatalogue(ProductID,ProdDesc,ProductName,UnitPrice,ProductQty)");
            sql.AppendLine("VALUES (@productID, @productDesc,@prodName, @UnitPrice,@productQty)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                cmd = new SqlCommand(sql.ToString(), conn);
                cmd.Parameters.AddWithValue("@productID", productID);
                cmd.Parameters.AddWithValue("@productDesc", ProductDesc);
                cmd.Parameters.AddWithValue("@prodName", name);

                cmd.Parameters.AddWithValue("@productQty", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                //cmd.Parameters.AddWithValue("@PONum", PONum);

                //   cmd.Parameters.AddWithValue("@poID", poID);
                //cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return result;

        }


        public int CreatePO(string PODate, string POStatus, decimal totalAmt, string companyName, string supplierName)
        {
            StringBuilder sql;
            SqlCommand sqlCmd;
            int result;

            result = 0;
            sql = new StringBuilder();
            sql.AppendLine("INSERT INTO PurchaseOrders(PoDate, PoStatus, PoTotalAmt, CompanyName, SupplierName)");
            sql.AppendLine("VALUES (@PODate, @POStatus, @TotalAmt, @CompanyName,@SupplierName)");
            SqlConnection conn = dbConn.GetConnection();
            conn.Open();

            try
            {
                sqlCmd = new SqlCommand(sql.ToString(), conn);
                sqlCmd.Parameters.AddWithValue("@PODate", PODate);
                sqlCmd.Parameters.AddWithValue("@POStatus", POStatus);
                sqlCmd.Parameters.AddWithValue("@TotalAmt", totalAmt);
                sqlCmd.Parameters.AddWithValue("@CompanyName", companyName);
                sqlCmd.Parameters.AddWithValue("@SupplierName", supplierName);
                result = sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return result;
        }



        public DataSet GetOrderDetails(int PONum)
        {
            string IDS;

            string queryStr = "SELECT ListOfProductID FROM PurchaseOrderItems WHERE PoID=@ID";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@ID", PONum);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //Continue to read the resultsets row by row if not the end
            dr.Read();
            IDS = dr["ListOfProductID"].ToString();
            conn.Close();
            List<int> idlist = new List<int>();
            foreach (var item in IDS.Split(','))
            {
                idlist.Add(int.Parse(item));
            }
            return GetProductUsingID(idlist.ToArray());
        }


        public DataSet GetProductUsingID(int[] IDs)
        {
            List<int> productsIds = new List<int>();

            foreach (var item in IDs)
                productsIds.Add(item);

            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();

            string items = string.Join(",", productsIds.ToArray());
            sql.AppendLine("SELECT *");
            sql.AppendLine("FROM ProductCatalogue");
            sql.AppendLine("WHERE CatalogueID IN ("+ items+")");

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

            //List<DalPurchaseOrders> prodList = GetProductCatalogueDetails();
            //List<DalPurchaseOrders> purchase = new List<DalPurchaseOrders>();
            //for (int i = 0; i < prodList.Count; i++)
            //{
            //    int id = -1;
            //    foreach (int item in IDs)
            //    {
            //        if (item != prodList[i].prodID)
            //            continue;

            //        id = item;
            //        break;
            //    }
            //    if (id == -1)
            //        continue;
            //    purchase.Add(prodList[i]);
            //}

            //return purchase;
        }


        public DalPurchaseOrders(int prodID, string prodDesc, decimal unitPrice)
        {
            this.prodID = prodID;
            this.prodDesc = prodDesc;

            this.unitPrice = unitPrice;

        }

        public DalPurchaseOrders()
        {

        }

        public List<DalPurchaseOrders> GetProductCatalogueDetails()
        {
            List<DalPurchaseOrders> prodList = new List<DalPurchaseOrders>();
            string prodDesc;
            decimal unitPrice;
            string queryStr = "SELECT ProductID,ProdDesc,UnitPrice FROM ProductCatalogue";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prodID = int.Parse(dr["ProductID"].ToString());
                prodDesc = dr["ProdDesc"].ToString();
                unitPrice = Convert.ToDecimal(dr["UnitPrice"].ToString());
                //   quantity = int.Parse(dr["ProductQty"].ToString());
                DalPurchaseOrders po = new DalPurchaseOrders(prodID, prodDesc, unitPrice);
                prodList.Add(po);
            }

            conn.Close();
            dr.Close();
            dr.Dispose();
            return prodList;



        }



        public DataSet updatePOStatus(int PoID)
        {
            StringBuilder sql;
            SqlDataAdapter da;
            DataSet ProgramData;

            SqlConnection conn = dbConn.GetConnection();

            ProgramData = new DataSet();
            sql = new StringBuilder();
            sql.AppendLine("UPDATE PurchaseOrderItems");
            sql.AppendLine("SET PoStatus = @POs");
            sql.AppendLine("WHERE PoID = @POId");

            try
            {
                da = new SqlDataAdapter(sql.ToString(), conn);
                da.SelectCommand.Parameters.AddWithValue("POId", PoID);
                da.SelectCommand.Parameters.AddWithValue("POs", "Processing");
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



















    }
}