using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace thebigfour
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsTheBigFour" in both code and config file together.
    [ServiceContract]
    public interface IWsTheBigFour
    {
        [OperationContract]
        DataSet GetAllPurchaseOrder();

        [OperationContract]
        DataSet GetAllProducts();

        [OperationContract]
        DataSet GetProductImage(int prodID);

    }
}
