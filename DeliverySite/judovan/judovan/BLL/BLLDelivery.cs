using judovan.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace judovan.BLL
{
    public class BLLDelivery
    {
        //public DataSet getAllDeliveryDetails()
        //{
        //    DalDelivery dal;
        //    DataSet ds;
        //    dal = new DalDelivery();
        //    ds = dal.GetAllProducts();
        //    return ds;
        //}
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

        public DataSet UpdateDeliveryInvoice(int id, int InvoiceID)
        {
            DalDelivery dal;
            DataSet ds;
            dal = new DalDelivery();
            ds = dal.UpdateDeliveryInvoice(id, InvoiceID);
            return ds;
        }

        //public void createDelivery(decimal weight, string deliveryStatus, int PoID, int invoiceID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty)
        //{
        //    DalDelivery dal;
        //    dal = new DalDelivery();
        //    //return dal.createDelivery(weight, deliveryStatus, PoID, invoiceID, dateRegistered, deliveryType, ProductDesc, ProductQty);
        //}

    }
}