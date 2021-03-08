using System;
using CustomerManagement.Abstract;
using CustomerManagement.Concrete;
using CustomerManagement.Entities;
using CustomerManagement.Adapters;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ömer Faruk";
            customer1.LastName = "Arslan";
            customer1.DateOfBirth = new DateTime(2000, 11, 7);
            customer1.NationalityId = "12345678910";

            customerManager.Save(customer1);
            Console.ReadLine();
        }
    }
}
