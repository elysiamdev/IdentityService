using System;
using Identity.Domain.Entities;
using Identity.Domain.ValueObjects;

using Xunit;

namespace Identity.Tests.Entities
{
    public class UserTests
    {
        [Fact]
        public void TestUser()
        {
            var name = new Name("Lucas", "Pedroso");
            var email = new Email("lucasreisPedroso@gmail.com");
            var password = new Password("1029301293");
            User user = new User(1, name, email, password);
            Assert.NotNull(user);
        }
    }
}