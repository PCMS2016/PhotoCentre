﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public interface IHandler_Customer
    {
        List<Customer> SearchCustomer(string Name, string Surname);
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        Customer GetNotificationDetails(int OrderNumber);
    }
}
