using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using boxwear.DAL;
using System.Data;

namespace boxwear.BLL
{
    public class BllDelivery
    {
        public DataSet GetDelivery()
        {
            DalDelivery dal;
            DataSet ds;
            dal = new DalDelivery();
            ds = dal.GetDelivery();
            return ds;
        }

        public DataSet GetDeliveryDetailsByID(int deliveryID)
        {
            DalDelivery dal;
            DataSet ds;
            dal = new DalDelivery();
            ds = dal.GetDeliveryDetailsByID(deliveryID);
            return ds;
        }
    }
}