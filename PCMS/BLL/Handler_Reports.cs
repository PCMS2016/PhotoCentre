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


        public List<Reports> GetMonthRefund(int month, int year)
        {
            return db.GetMonthRefund(month, year);
        }

        public List<Reports> GetMonthSales(int month, int year)
        {
            return db.GetMonthSales(month, year);
        }

        public List<Reports> GetMonthProduct(int month, int year)
        {
            return db.GetMonthSales(month, year);
        }
        
        public List<Reports> GetYearSales(int year)
        {
            return db.GetYearSales(year);
        }

        public List<Reports> GetYearProduct(int year)
        {
            return db.GetYearProduct(year);
        }

        public Reports[] ChartSalespersonSalesYear(int year)
        {
            return db.ChartSalespersonSalesYear(year);
        }
        
        public Reports[] ChartProductSalesYear(int year)
        {
            return db.ChartProductSalesYear(year);
        }


        public Reports[] ChartProductsSoldYear(int year)
        {
            return db.ChartProductsSoldYear(year);
        }
}
}
