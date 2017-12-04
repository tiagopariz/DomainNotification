using System;
using DomainNotification.Domain.Notifications;
using DomainNotification.Domain.ValueObjects;

namespace DomainNotification.Domain.Entities
{
    public class Person : EntityBase
    {
        public Person(Guid personId, string name, Email email)
        {
            PersonId = personId;
            Name = name;
            Email = email;
            Validate();
        }

        public sealed override void Validate()
        {
            IsInvalidGuid(PersonId, InvalidId);
            IsInvalidName(Name, InvalidName);
            IsInvalidEmail(Email, InvalidPersonEmail);
        }

        protected void IsInvalidEmail(Email s, Error error)
        {
            Fail(Email.Notification.HasErrors, error);
        }

        public Guid PersonId { get; }
        public string Name { get; }
        public Email Email { get; }

        public static Error InvalidPersonEmail = new Error("Invalid E-mail, see object notifications for more details.");
    }
}
