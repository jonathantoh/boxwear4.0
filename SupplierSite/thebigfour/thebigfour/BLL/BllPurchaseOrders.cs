using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllPurchaseOrders
    {
        public DataSet GetCO()
        {
            DalPurchaseOrders dal;
            DataSet dataSetCOList;
            dal = new DalPurchaseOrders();
            dataSetCOList = dal.GetOrder();
            return dataSetCOList;
        }

        public DataSet GetOrderDetails(int PONum)
        {
            DalPurchaseOrders dal;
            DataSet dataSetOrdDetailList;

            dal = new DalPurchaseOrders();
            dataSetOrdDetailList = dal.GetOrderDetails(PONum);

            return dataSetOrdDetailList;
        }

        public DataSet updatePOStatus(int PoID)
        {
            DalPurchaseOrders dal;
            DataSet dataSetStatus;
            dal = new DalPurchaseOrders();
            dataSetStatus = dal.updatePOStatus(PoID);
            return dataSetStatus;
        }

    
    }
}