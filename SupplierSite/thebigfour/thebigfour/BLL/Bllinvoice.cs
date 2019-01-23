using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class Bllinvoice
    {
        public DataSet GetAllInvoice()
        {
            Dalinvoice dal;
            DataSet invoicedata;
            dal = new Dalinvoice();
            invoicedata = dal.GetAllInvoice();
            return invoicedata;
        }

        public DataSet GetInvoiceByID(int InvoiceID)
        {
            Dalinvoice dal;
            DataSet invoicedata;
            dal = new Dalinvoice();
            invoicedata = dal.GetInvoiceByID(InvoiceID);
            return invoicedata;
        }

        public DataSet GetInvoiceByTrackingID(int trackingID)
        {
            Dalinvoice dal;
            DataSet invoicedata;
            dal = new Dalinvoice();
            invoicedata = dal.GetInvoiceByTrackingID(trackingID);
            return invoicedata;
        }

        public int insertInvoice(DateTime InvoiceDate, decimal InvoiceAmt, string InvoiceStatus, int PoID, int trackingID, DateTime endDate)
        {
            int result = 0;
            Dalinvoice d = new Dalinvoice();
            return result = d.CreatePOI(InvoiceDate, InvoiceAmt, InvoiceStatus, PoID, trackingID, endDate);
        }

        public DataSet UpdateInvoicePayment(int InvoiceID, string ccNo, string ccv, string expDate, string status, DateTime paymentDate, string paymentMadeBy)
        {
            Dalinvoice dal;
            DataSet invoicedata;
            dal = new Dalinvoice();
            invoicedata = dal.updateInvoicePayment(InvoiceID, ccNo, ccv, expDate, status, paymentDate, paymentMadeBy);
            return invoicedata;
        }
    }
}