using System.Collections;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Interfaces.Notifications
{
    public interface INotification
    {
        IList Errors { get; set; }
        IList Warnings { get; set; }
        IList Messages { get; set; }
        bool HasErrors { get; }
        bool HasWarnings { get; }
        bool HasMessages { get; }
        bool HasNotifications { get; }

        bool IncludesError(Error error);
        bool IncludesWarning(Warning warning);
        bool IncludesMessage(Message message);
    }
}
