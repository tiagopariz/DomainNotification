namespace DomainNotification.Domain.Notifications
{
    public class Warning
    {
        private readonly string _message;
        
        public Warning(string message, params string[] args)
        {
            _message = message;

            for (var i = 0; i < args.Length; i++)
            {
                _message = _message.Replace("{" + i + "}", args[i]);
            }
        }

        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Warning;

        public override string ToString()
        {
            return _message;
        }
    }
}