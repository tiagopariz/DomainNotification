namespace DomainNotification.Domain.Notifications
{
    public class Message
    {
        private readonly string _message;
        public Message(string message)
        {
            _message = message;
        }

        public override string ToString()
        {
            return _message;
        }
    }
}