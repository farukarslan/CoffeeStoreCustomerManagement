using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Abstract;
using CustomerManagement.Entities;

namespace CustomerManagement.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {

        private ICustomerCheckService _customerCheckService; //Dependecy injection yöntemi ile initialize ettik.

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person!");
            }

        }
    }
}
