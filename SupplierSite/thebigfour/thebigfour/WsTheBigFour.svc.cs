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

        //jon's part
        public DataSet GetDeliveryDetailsByID(int id)
        {
            thebigfour.BLL.BllDeliveryOrders bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.BllDeliveryOrders();
            return bizLayerPrograms.GetDeliveryDetailsByID(id);
        }

        public DataSet GetAll()
        {
            thebigfour.BLL.BllDeliveryOrders bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.BllDeliveryOrders();
            return bizLayerPrograms.GetAll();
        }

        public DataSet updateDOStatus(int DoID, string status)
        {
            thebigfour.BLL.BllDeliveryOrders bizLayerProgram;
            bizLayerProgram = new thebigfour.BLL.BllDeliveryOrders();
            return bizLayerProgram.updateDOStatus(DoID, status);
        }

        //invoice
        public DataSet GetInvoiceByID(int id)
        {
            thebigfour.BLL.Bllinvoice bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.Bllinvoice();
            return bizLayerPrograms.GetInvoiceByID(id);
        }

        public DataSet GetAllInvoice()
        {
            thebigfour.BLL.Bllinvoice bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.Bllinvoice();
            return bizLayerPrograms.GetAllInvoice();
        }

        public DataSet UpdateInvoicePayment(int InvoiceID, string ccNo, string ccv, string expDate, string status, DateTime paymentDate, string paymentMadeBy)
        {
            thebigfour.BLL.Bllinvoice bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.Bllinvoice();
            return bizLayerPrograms.UpdateInvoicePayment(InvoiceID, ccNo, ccv, expDate, status, paymentDate, paymentMadeBy);
        }

        public int insertInvoice(DateTime InvoiceDate, decimal InvoiceAmt, string InvoiceStatus, int PoID, int trackingID, DateTime endDate)
        {
            thebigfour.BLL.Bllinvoice bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.Bllinvoice();
            return bizLayerPrograms.insertInvoice(InvoiceDate, InvoiceAmt, InvoiceStatus, PoID, trackingID, endDate);
        }

        public DataSet GetInvoiceByTrackingID(int trackingID)
        {
            thebigfour.BLL.Bllinvoice bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.Bllinvoice();
            return bizLayerPrograms.GetInvoiceByTrackingID(trackingID);

        }

        public DataSet updateDeliveryInvoice(int id, int InvoiceID)
        {
            thebigfour.BLL.BllDeliveryOrders bizLayerPrograms;
            bizLayerPrograms = new thebigfour.BLL.BllDeliveryOrders();
            return bizLayerPrograms.updateDeliveryInvoice(id, InvoiceID);

        }


    }
}
