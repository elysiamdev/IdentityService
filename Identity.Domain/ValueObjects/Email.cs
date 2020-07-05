using System;
using Flunt.Validations;
using Identity.Shared.ValueObjects;
namespace Identity.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }
    }
}