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

        public int CreatePOI(int productID, string productName, int quantity, decimal unitPrice,  decimal totalPrice)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.CreatePOI(productID, productName, quantity, unitPrice, totalPrice);
        }

        public int CreatePO(string PODate, string POStatus, decimal POAmt,string companyName,string supplierName)
        {
            DalPurchaseOrders dataLayerProgram;
            dataLayerProgram = new DalPurchaseOrders();
            return dataLayerProgram.CreatePO(PODate, POStatus, POAmt, companyName, supplierName);
        }
    }
}