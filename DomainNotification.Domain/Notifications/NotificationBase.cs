using System.Collections;
using DomainNotification.Domain.Interfaces.Notifications;

namespace DomainNotification.Domain.Notifications
{
    public abstract class NotificationBase : INotification
    {
        public IList Errors { get; set; } = new ArrayList();
        public IList Warnings { get; set; } = new ArrayList();
        public IList Messages { get; set; } = new ArrayList();
        public bool HasErrors => 0 != Errors.Count;
        public bool HasWarnings => 0 != Warnings.Count;
        public bool HasMessages => 0 != Messages.Count;
        public bool HasNotifications => HasErrors || HasWarnings || HasWarnings;

        public bool IncludesError(Error error)
        {
            return Errors.Contains(error);
        }

        public bool IncludesWarning(Warning warning)
        {
            return Warnings.Contains(warning);
        }

        public bool IncludesMessage(Message message)
        {
            return Messages.Contains(message);
        }
    }
}
