namespace DomainNotification.Domain.Notifications
{
    public class Error
    {
        private readonly string _message;
        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Error;

        public Error(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }
    }
}