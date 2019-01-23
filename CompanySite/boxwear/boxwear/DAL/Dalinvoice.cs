using boxwear.SvcRefTheBigFour;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace boxwear.DAL
{
    public class Dalinvoice
    {
        public DataSet GetAllInvoice()
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetAllInvoice();
        }

        public DataSet GetInvoiceByID(int id)
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.GetInvoiceByID(id);
        }
        public DataSet updateInvoicePayment(int InvoiceID, string ccNo, string ccv, string expDate, string status, DateTime paymentDate, string paymentMadeBy)
        {
            WsTheBigFourClient d;
            d = new WsTheBigFourClient();
            return d.UpdateInvoicePayment(InvoiceID, ccNo, ccv, expDate, status, paymentDate, paymentMadeBy);
        }

    }
}