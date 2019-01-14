using boxwear.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace boxwear
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsBoxWear" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WsBoxWear.svc or WsBoxWear.svc.cs at the Solution Explorer and start debugging.
    public class WsBoxWear : IWsBoxWear
    {
        public DataSet GetPOList()
        {
            boxwear.BLL.BllPurchaseOrders bizLayerPrograms;
            bizLayerPrograms = new boxwear.BLL.BllPurchaseOrders();
            return bizLayerPrograms.GetPOList();
        }

        public DataSet GetOrderDetails(int PONum)
        {
            boxwear.BLL.BllPurchaseOrders bizLayerProgram;
            bizLayerProgram = new boxwear.BLL.BllPurchaseOrders();
            return bizLayerProgram.GetOrderDetails(PONum);
        }

        //public List<DalPurchaseOrders> GetProductUsingID(int[] IDs)
        //{
        //    boxwear.BLL.BllPurchaseOrders bizLayerProgram;
        //    bizLayerProgram = new boxwear.BLL.BllPurchaseOrders();
        //    return bizLayerProgram.GetProductUsingID(IDs);
        //}

    }
}
