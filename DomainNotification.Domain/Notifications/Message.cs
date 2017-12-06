namespace DomainNotification.Domain.Notifications
{
    public class Message
    {
        private readonly string _message;

        public Message(string message, params string[] args)
        {
            _message = message;

            for (var i = 0; i < args.Length; i++)
            {
                _message = _message.Replace("{" + i + "}", args[i]);
            }
        }

        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Message;

        public override string ToString()
        {
            return _message;
        }
    }
}