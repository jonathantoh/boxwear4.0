using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace thebigfour
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsTheBigFour" in both code and config file together.
    [ServiceContract]
    public interface IWsTheBigFour
    {
        [OperationContract]
        DataSet GetAllPurchaseOrder();

        [OperationContract]
        DataSet GetAllProducts();

        //[OperationContract]
        //DataSet GetProductImage(int prodID);


        //jon's part
        [OperationContract]
        DataSet GetAll();

        [OperationContract]
        DataSet GetDeliveryDetailsByID(int id);

        [OperationContract]
        DataSet updateDOStatus(int id, string status);

        [OperationContract]
        DataSet GetInvoiceByID(int id);

        [OperationContract]
        DataSet GetAllInvoice();

        [OperationContract]
        DataSet UpdateInvoicePayment(int InvoiceID,string ccNo, string ccv, string expDate, string status, DateTime paymentDate, string paymentMadeBy);

        [OperationContract]
        int insertInvoice(DateTime InvoiceDate, decimal InvoiceAmt, string InvoiceStatus, int PoID, int trackingID, DateTime endDate);

        [OperationContract]
        DataSet updateDeliveryInvoice(int id, int InvoiceID);

        [OperationContract]
        DataSet GetInvoiceByTrackingID(int trackingID);
    }
}
