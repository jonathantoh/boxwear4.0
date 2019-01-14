using boxwear.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace boxwear.BLL
{
    public class BllPurchaseOrders
    {
        public DataSet GetPOList()
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetPOList();
        }

        public DataSet GetPOItems()
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetPOItems();
        }


        public DataSet GetPOListFiltered(string status)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetPOListFiltered(status);
        }

        public int GetPoID()
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetPoID();
        }


        public DataSet GetProductCatalogue()
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetProductCatalogue();
        }

        public int CreatePOI(string productID, string ProductDesc, string quantity, string unitPrice)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.CreatePOI(productID, ProductDesc, quantity, unitPrice);
        }

        public int InsertCatalogue(int productID, string name, string ProductDesc, int quantity, decimal unitPrice)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.InsertCatalogue(productID,name,ProductDesc, quantity, unitPrice);
        }

        public int CreatePO(string PODate, string POStatus, decimal POAmt,string companyName,string supplierName)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.CreatePO(PODate, POStatus, POAmt, companyName, supplierName);
        }

        public DataSet GetOrderDetails(int PONum)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.GetOrderDetails(PONum);
        }

        //public List<DalPurchaseOrders> GetProductUsingID(int[] IDs)
        //{
        //    DalPurchaseOrders dataLayerProgram;
        //    dataLayerProgram = new DalPurchaseOrders();
        //    return dataLayerProgram.GetProductUsingID(IDs);
        //}
    }
}