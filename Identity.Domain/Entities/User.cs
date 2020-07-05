using Identity.Domain.ValueObjects;
using Identity.Shared.Entities;

namespace Identity.Domain.Entities
{
    public class User : Entity
    {
        public int UserId { get; set; }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
    }
}