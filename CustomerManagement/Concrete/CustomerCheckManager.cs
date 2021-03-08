using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Abstract;
using CustomerManagement.Entities;

namespace CustomerManagement.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
