namespace DomainNotification.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;
            Validate();
        }

        public sealed override void Validate()
        {
            IsInvalidEmail(Address, InvalidEmail);
        }

        public string Address { get; }
    }
}