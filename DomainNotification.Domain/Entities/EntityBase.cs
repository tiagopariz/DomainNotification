using System;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Entities
{
    public class EntityBase
    {
        public Notification Notification { get; } = new Notification();

        public virtual void Validate()
        {
            
        }

        protected void IsInvalidGuid(Guid guid, Error error)
        {
            Fail(guid == Guid.Empty, error);
        }

        protected void IsInvalidName(string s, Error error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }

        protected void Fail(bool condition, Error error)
        {
            if (condition)
                Notification.Errors.Add(error);
        }

        public bool IsValid()
        {
            return !Notification.HasErrors;
        }

        #region Errors

        public static Error InvalidId = new Error("Invalid Id");
        public static Error InvalidName = new Error("Invalid Name");

        #endregion
    }
}
