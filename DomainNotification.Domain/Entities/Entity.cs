using System;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.Entities
{
    public class Entity
    {
        public Error Errors { get; } = new Error();

        public virtual void Validate() { }

        protected void IsInvalidGuid(Guid guid, ErrorDescription error)
        {
            Fail(guid == Guid.Empty, error);
        }

        protected void IsInvalidName(string s, ErrorDescription error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }

        protected void Fail(bool condition, ErrorDescription description)
        {
            if (condition)
                Errors.Add(description);
        }

        public bool IsValid()
        {
            return !Errors.HasErrors;
        }

        #region Errors

        public static ErrorDescription InvalidId = new ErrorDescription("Invalid Id", Level.Error);
        public static ErrorDescription InvalidName = new ErrorDescription("Invalid Name", Level.Error);

        #endregion
    }
}