using DomainNotification.Domain.Interfaces.Errors;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Errors
{
    public class ErrorDescription : Description
    {
        public ILevel Level { get; }

        public ErrorDescription(string message, ILevel level, params string[] args)
            : base(message, args)
        {
            Level = level;
        }
    }
}