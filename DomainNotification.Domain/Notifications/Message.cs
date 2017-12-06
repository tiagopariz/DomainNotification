namespace DomainNotification.Domain.Notifications
{
    public class Message
    {
        private readonly string _message;

        public Message(string message)
        {
            _message = message;
        }

        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Message;

        public override string ToString()
        {
            return _message;
        }
    }
}