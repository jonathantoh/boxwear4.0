using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using thebigfour.SvcRefBoxWear;

namespace thebigfour.DAL
{
    public class DalPurchaseOrders
    {
        private String errMsg;
        DalDbConn dbConn = new DalDbConn();
        public DataSet GetOrder()
        {
            WsBoxWearClient programSupplierClient;
            programSupplierClient = new WsBoxWearClient();
            return programSupplierClient.GetPOList();
        }

        public DataSet GetOrderDetails(int PONum)
        {
            WsBoxWearClient programSupplierClient;
            programSupplierClient = new WsBoxWearClient();
            return programSupplierClient.GetOrderDetails(PONum);
        }

        //public DataSet GetProductUsingID(int[] IDs)
        //{
        //    WsBoxWearClient programSupplierClient;
        //    programSupplierClient = new WsBoxWearClient();
        //    return programSupplierClient.GetProductUsingID(IDs);
        //}



    }
}