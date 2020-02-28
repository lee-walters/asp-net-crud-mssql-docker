using System;

namespace Pitstop.CustomerManagementAPI.Commands
{
    public class RegisterCustomer
    {
        public readonly string Name;
        public readonly string Address;
        public readonly string PostalCode;
        public readonly string City;
        public readonly string TelephoneNumber;
        public readonly string EmailAddress;

        public RegisterCustomer(string name, string address, string postalCode, string city, string telephoneNumber, string emailAddress)
        {
            Name = name;
            Address = address;
            PostalCode = postalCode;
            City = city;
            TelephoneNumber = telephoneNumber;
            EmailAddress = emailAddress;
        }
    }
}
