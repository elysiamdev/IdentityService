using System;
using Flunt.Validations;
using Identity.Shared.ValueObjects;
namespace Identity.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; set; }
    }
}