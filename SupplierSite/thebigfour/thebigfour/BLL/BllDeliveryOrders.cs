using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllDeliveryOrders
    {
        public int DeliveryInsert(decimal weight, string deliveryStatus, int PoID, string dateRegistered, string deliveryType, string ProductDesc, int ProductQty, string company, decimal value)
        {
            int result = 0;

            DalDeliveryOrders d = new DalDeliveryOrders();
            return result = d.DeliveryInsert(weight, deliveryStatus, PoID, dateRegistered, deliveryType, ProductDesc, ProductQty, company, value);
        }

        public DataSet GetAll()
        {
            DalDeliveryOrders dataLayerProgram;
            dataLayerProgram = new DalDeliveryOrders();
            return dataLayerProgram.GetAll();
        }

        public DataSet GetDeliveryDetailsByID(int id)
        {
            DalDeliveryOrders dataLayerProgram;
            dataLayerProgram = new DalDeliveryOrders();
            return dataLayerProgram.GetDeliveryDetailsByID(id);
        }

        public DataSet updateDOStatus(int id, string status)
        {
            DalDeliveryOrders dataLayerProgram;
            dataLayerProgram = new DalDeliveryOrders();
            return dataLayerProgram.updateDOStatus(id, status);
        }

        public DataSet updateDeliveryInvoice(int id, int InvoiceID)
        {
            DalDeliveryOrders dataLayerProgram;
            dataLayerProgram = new DalDeliveryOrders();
            return dataLayerProgram.updateDeliveryInvoice(id, InvoiceID);
        }
    }
}