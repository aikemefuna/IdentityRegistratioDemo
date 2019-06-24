using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityRegistrationDemo.Domain.ResponseModels
{
    public class CitizenResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string StateOfOrigin { get; set; }
        public string LGA { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceAddress { get; set; }      
        public string ReferencePhoneNumber { get; set; }
        public string Occupation { get; set; }
        public string MotherMaidenName { get; set; }
        public long BVN { get; set; }
        public string NIN { get; set; }
    }
}
