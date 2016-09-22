﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public interface IHandler_Reports
    {
        DataTable GetAllProducts(DateTime start, DateTime end);
        DataTable GetAllProductsRefunds(DateTime start, DateTime end);
    }
}
