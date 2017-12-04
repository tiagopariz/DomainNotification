using DomainNotification.Domain.Entities;

namespace DomainNotification.Domain.ValueObjects
{
    public class Email : ValueObjectBase
    {
        public Email(string address)
        {
            Address = address;
            Validate();
        }

        public sealed override void Validate()
        {
            IsInvalidEmail(Address, EntityBase.InvalidName);
        }

        public string Address { get; }
    }
}
