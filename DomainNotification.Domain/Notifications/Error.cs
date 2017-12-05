namespace DomainNotification.Domain.Notifications
{
    public class Error
    {
        private readonly string _message;
        public NotificationSeverity NotificationSeverity { get; } = NotificationSeverity.Error;

        public Error(string message, params string[] args)
        {
            _message = message;

            for (var i = 0; i < args.Length - 1; i++)
            {
                _message = _message.Replace($"{i}", args[i]);
            }
        }

        public override string ToString()
        {
            return _message;
        }
    }
}