namespace DomainNotification.Domain.Interfaces.Notifications
{
    public interface IDescription
    {
        string Message { get; }

        string ToString();
    }
}
