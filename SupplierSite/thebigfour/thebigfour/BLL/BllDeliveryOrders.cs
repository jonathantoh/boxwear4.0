using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllDeliveryOrders
    {
        public int DeliveryInsert(int PoID, int prodID, string prodDesc, int productQty, string status, string date)
        {
            DalDeliveryOrders d = new DalDeliveryOrders();
            return d.DeliveryInsert(PoID, prodID, prodDesc, productQty, status, date);
        }
    }
}