using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email: ValueObject
    {
        public string address { get; private set; }

        public Email(string address)
        {
            this.address = address;
        }
    }
}