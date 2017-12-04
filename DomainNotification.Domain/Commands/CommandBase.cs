using DomainNotification.Domain.Entities;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Commands
{
    public class CommandBase
    {
        public CommandBase(EntityBase entityBase)
        {
            EntityBase = entityBase;
        }

        protected EntityBase EntityBase;
        protected Notification Notification => EntityBase.Notification;
    }
}