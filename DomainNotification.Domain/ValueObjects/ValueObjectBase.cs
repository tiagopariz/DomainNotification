using System.Text.RegularExpressions;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.ValueObjects
{
    public class ValueObjectBase
    {
        public Error Notification { get; } = new Error();

        public virtual void Validate() { }

        protected void IsInvalidEmail(string s, ErrorDescription error)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            Fail(!Regex.IsMatch(s, pattern), error);
        }

        protected void Fail(bool condition, ErrorDescription error)
        {
            if (condition)
                Notification.Add(error);
        }

        public bool IsValid()
        {
            return !Notification.HasErrors;
        }

        #region Errors

        public static ErrorDescription InvalidEmail = new ErrorDescription("Invalid E-mail address", Level.Error);

        #endregion
    }
}
