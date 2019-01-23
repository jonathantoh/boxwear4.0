using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace judovan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsJudoVan" in both code and config file together.
    [ServiceContract]
    public interface IWsJudoVan
    {
        //[OperationContract]
        //DataSet getDeliveryStatus(int trackingID);

        //[OperationContract]
        //void createDelivery(decimal weight, string deliveryStatus, int PoID, int invoiceID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty);
    }
}
