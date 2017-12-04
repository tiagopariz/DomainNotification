using System.Collections;
using DomainNotification.Domain.Entities;

namespace DomainNotification.Application.Services
{
    public abstract class ServiceBase
    {
        protected EntityBase NotificationEntity;

        public bool HasNotifications()
        {
            return NotificationEntity != null && NotificationEntity.Notification.HasNotifications;
        }

        public IList Errors()
        {
            return NotificationEntity?.Notification.Errors;

        }

        public IList Warnings()
        {
            return NotificationEntity?.Notification.Warnings;
        }

        public IList Messages()
        {
            return NotificationEntity?.Notification.Messages;
        }
    }
}
