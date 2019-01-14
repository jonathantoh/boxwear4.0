using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace thebigfour
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsTheBigFour" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WsTheBigFour.svc or WsTheBigFour.svc.cs at the Solution Explorer and start debugging.
    public class WsTheBigFour : IWsTheBigFour
    {
        // purchase order 
        public DataSet GetAllPurchaseOrder()
        {
            thebigfour.BLL.BllPurchaseOrder bizLayerPO;
            bizLayerPO = new thebigfour.BLL.BllPurchaseOrder();
            return bizLayerPO.GetAllPurchaseOrder();
        }

        // product catalogue 
        public DataSet GetAllProducts()
        {
            thebigfour.BLL.BllProducts bizLayerProducts;
            bizLayerProducts = new thebigfour.BLL.BllProducts();
            return bizLayerProducts.GetAllProducts();
        }

        //public DataSet GetProductImage(int prodID)
        //{
        //    thebigfour.BLL.BllProducts bizLayerProducts;
        //    bizLayerProducts = new thebigfour.BLL.BllProducts();
        //    return bizLayerProducts.GetProductImage(prodID);
        //}
    }
}
