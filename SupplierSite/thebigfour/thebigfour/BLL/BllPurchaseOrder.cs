using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllPurchaseOrder
    {
        public DataSet GetAllPurchaseOrder()
        {
            DalViewPurchaseOrder dataLayerPO;
            dataLayerPO = new DalViewPurchaseOrder();
            return dataLayerPO.GetAllPurchaseOrder();
        }
    }
}