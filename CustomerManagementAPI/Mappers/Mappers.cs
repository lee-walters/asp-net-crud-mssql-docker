using Pitstop.CustomerManagementAPI.Commands;
using Pitstop.CustomerManagementAPI.Model;

namespace Pitstop.CustomerManagementAPI.Mappers
{
    public static class Mappers
    {
        public static Customer MapToCustomer(this RegisterCustomer command) => new Customer
        {
            CustomerId = System.Guid.NewGuid().ToString(),
            Name = command.Name,
            Address = command.Address,
            PostalCode = command.PostalCode,
            City = command.City,
            TelephoneNumber = command.TelephoneNumber,
            EmailAddress = command.EmailAddress
        };
    }
}