namespace Identity.Domain.ValueObjects
{
    public class Password
    {
        public Password(string secret)
        {
            Secret = secret;
        }

        public string Secret { get; private set; }
    }
}