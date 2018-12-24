using boxwear.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace boxwear.BLL
{
    public class BllProducts
    {
        public DataSet GetAllProducts()
        {
            DalProducts dal;
            DataSet ds;
            dal = new DalProducts();
            ds = dal.GetAllProducts();
            return ds;
        }

        public DataSet GetProductImage()
        {
            DalProducts dal;
            DataSet ds;
            dal = new DalProducts();
            ds = dal.GetProductImage();
            return ds;
        }

    }
}