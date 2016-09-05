using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Handler_Reports : IHandler_Reports
    {
        IDBAccess_Reports db = null;

        public Handler_Reports()
        {
            db = new DBAccess_Reports();
        }

        public List<Reports> GetDayRefund(DateTime day)
        {
            return db.GetDayRefund(day);
        }


        public List<Reports> GetDaySales(DateTime day)
        {
            return db.GetDaySales(day);
        }


        public List<Reports> GetDayProduct(DateTime day)
        {
            return db.GetDayProduct(day);
        }


        public List<Reports> GetMonthRefund(int month)
        {
            return db.GetMonthRefund(month);
        }

        public List<Reports> GetMonthSales(int month)
        {
            return db.GetMonthSales(month);
        }

        public List<Reports> GetMonthProduct(int month)
        {
            return db.GetMonthSales(month);
        }
    }
}
