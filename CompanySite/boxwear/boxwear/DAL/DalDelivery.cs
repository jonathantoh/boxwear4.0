using boxwear.SvcRefTheBigFour;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace boxwear.DAL
{
    public class DalDelivery
    {
        public DataSet GetDelivery()
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetAll();
        }

        public DataSet GetDeliveryDetailsByID(int id)
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetDeliveryDetailsByID(id);
        }
    }
}