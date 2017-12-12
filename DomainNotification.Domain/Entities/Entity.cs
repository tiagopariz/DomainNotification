using System;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.Entities
{
    public class Entity
    {
        public Error Errors { get; } = new Error();

        public virtual void Validate() { }

        protected void Fail(bool condition, ErrorDescription description)
        {
            if (condition)
                Errors.Add(description);
        }

        public bool IsValid()
        {
            return !Errors.HasErrors;
        }

        #region Validations

        protected void IsInvalidGuid(Guid guid, ErrorDescription error)
        {
            Fail(guid == Guid.Empty, error);
        }

        protected void IsInvalidName(string s, ErrorDescription error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }

        #endregion

        #region Errors

        public static ErrorDescription InvalidId = new ErrorDescription("Invalid Id", new Critical());
        public static ErrorDescription InvalidName = new ErrorDescription("Invalid Name", new Critical());

        #endregion
    }
}