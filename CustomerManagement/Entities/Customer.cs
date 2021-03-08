using CustomerManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Entities //Klasörün içine sonradan eklersek namespace sonuna ".Entities" eklememiz gerekir.
{                                     //Direkt klasörün içine açarsak bir değişikliğe gerek kalmıyor.
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
