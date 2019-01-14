using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using thebigfour.DAL;

namespace thebigfour.BLL
{
    public class BllCustomerOrders
    {
        public DataSet GetAllCO()
        {
            DalCustomerOrders dal = new DalCustomerOrders();
            return dal.GetAllCO();
        }

        public int InsertCO(int poNum,string comName,string date,decimal amt,string addr,string stat)
        {
            DalCustomerOrders dal = new DalCustomerOrders();
            return dal.InsertCO(poNum,comName,date,amt,addr,stat);
        }


    }
}