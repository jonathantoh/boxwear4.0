using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using boxwear.DAL;

namespace boxwear.BLL
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