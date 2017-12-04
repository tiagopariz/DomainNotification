using System;
using System.Text.RegularExpressions;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.ValueObjects
{
    public class ValueObjectBase
    {
        public Notification Notification { get; } = new Notification();

        public virtual void Validate()
        {

        }

        protected void IsInvalidEmail(string s, Error error)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Fail(!Regex.IsMatch(s, pattern), error);
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

        // ERRORS

        public static Error InvalidEmail = new Error("Invalid E-mail address");
    }
}
