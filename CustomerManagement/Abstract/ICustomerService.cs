using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Entities;

namespace CustomerManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
