using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Errors
{
    public class ErrorDescription : Description
    {
        public Level Level { get; }

        public ErrorDescription(string message, Level level, params string[] args)
            : base(message, args)
        {
            Level = level;
        }
    }
}