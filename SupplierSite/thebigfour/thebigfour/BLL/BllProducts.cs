using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllProducts
    {
        public DataSet GetAllProducts()
        {
            DalProducts dal;
            DataSet dataSetProductList;
            dal = new DalProducts();
            dataSetProductList = dal.GetAllProducts();
            return dataSetProductList;
        }

        //KIV
        public DataSet GetProductImage(int prodID)
        {
            DalProducts dal;
            DataSet dataSetProductList;
            dal = new DalProducts();
            dataSetProductList = dal.GetProductImage(prodID);
            return dataSetProductList;
        }
    }
}