using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace judovan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsJudoVan" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WsJudoVan.svc or WsJudoVan.svc.cs at the Solution Explorer and start debugging.
    public class WsJudoVan : IWsJudoVan
    {
        //public DataSet getDeliveryStatus(int trackingID)
        //{
        //    judovan.BLL.BLLDelivery bizLayerBooks;
        //    bizLayerBooks = new judovan.BLL.BLLDelivery();
        //    return bizLayerBooks.getDeliveryStatus(trackingID);
        //}

        //public int createDelivery(decimal weight, string deliveryStatus, int PoID, int invoiceID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty)
        //{
        //    judovan.BLL.BLLDelivery bizLayerBooks;
        //    bizLayerBooks = new judovan.BLL.BLLDelivery();
        //    return bizLayerBooks.createDelivery(weight, deliveryStatus, PoID, invoiceID, dateRegistered, deliveryType, ProductDesc, ProductQty);
        //}
    }
}
