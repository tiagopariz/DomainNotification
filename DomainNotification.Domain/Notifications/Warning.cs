namespace DomainNotification.Domain.Notifications
{
    public class Warning
    {
        private readonly string _message;
        
        public Warning(string message)
        {
            _message = message;
        }

        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Warning;

        public override string ToString()
        {
            return _message;
        }
    }
}