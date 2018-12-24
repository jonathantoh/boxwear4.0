using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace boxwear
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsBoxWear" in both code and config file together.
    [ServiceContract]
    public interface IWsBoxWear
    {
        [OperationContract]
        DataSet GetPOList();
    }
}
