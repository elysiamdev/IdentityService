using Identity.Domain.ValueObjects;
using Identity.Shared.Entities;

namespace Identity.Domain.Entities
{
    public class User : Entity
    {
        public User(int userId, Name name, Email email, Password password)
        {
            UserId = userId;
            Name = name;
            Email = email;
            Password = password;
        }

        public int UserId { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
    }
}