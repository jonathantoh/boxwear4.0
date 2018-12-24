
using boxwear.SvcRefTheBigFour;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace boxwear.DAL
{
    public class DalProducts
    {
        public DataSet GetAllProducts()
        {
           WsTheBigFourClient ProdSupplierClient;
            ProdSupplierClient = new WsTheBigFourClient();
            return ProdSupplierClient.GetAllProducts();
        }

        public DataSet GetProductImage()
        {
            WsTheBigFourClient ProdSupplierClient;
            ProdSupplierClient = new WsTheBigFourClient();
            return ProdSupplierClient.GetProductImage();
        }
    }
}