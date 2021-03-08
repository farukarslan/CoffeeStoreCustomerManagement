using System;
using System.Collections.Generic;
using System.Text;
using CustomerManagement.Entities;

namespace CustomerManagement.Abstract
{
    //İki CustomerManager'ın da save işlemi aynı olduğu için BaseCustomerManager açtık.
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //virtual kullanırsak bu metodu ezebiliriz(override edilebilir olur) demektir.
        {
            Console.WriteLine("Saved to database : " + customer.FirstName);
        }
    }
}
