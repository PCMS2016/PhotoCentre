using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Reports
    {
        List<Reports> GetDayRefund(DateTime day);
        List<Reports> GetDaySales(DateTime day);
        List<Reports> GetDayProduct(DateTime day);
        List<Reports> GetMonthRefund(int month);
        List<Reports> GetMonthSales(int month);
        List<Reports> GetMonthProduct(int month);
        /*List<Reports> GetYearRefund(DateTime day);
        List<Reports> GetYearSales(DateTime day);
        List<Reports> GetYearProduct(DateTime day);*/
    }
}
