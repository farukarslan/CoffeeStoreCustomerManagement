using CustomerManagement.Abstract;
using CustomerManagement.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace CustomerManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
            (Convert.ToInt64(customer.NationalityId), customer.FirstName,customer.LastName,customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
