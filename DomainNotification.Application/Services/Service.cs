using System.Collections;
using DomainNotification.Domain.Entities;

namespace DomainNotification.Application.Services
{
    public abstract class Service
    {
        protected Entity NotificationEntity;

        public bool HasNotifications => NotificationEntity != null && NotificationEntity.Errors.HasNotifications;
        public bool HasErrors => NotificationEntity != null && NotificationEntity.Errors.HasErrors;
        public bool HasWarnings => NotificationEntity != null && NotificationEntity.Errors.HasWarnings;
        public bool HasInformations => NotificationEntity != null && NotificationEntity.Errors.HasInformations;

        public IEnumerable Errors()
        {
            return NotificationEntity?.Errors.Errors;
        }

        public IEnumerable Warnings()
        {
            return NotificationEntity?.Errors.Warnings;
        }

        public IEnumerable Informations()
        {
            return NotificationEntity?.Errors.Informations;
        }
    }
}