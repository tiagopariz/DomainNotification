using DomainNotification.Domain.Entities;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.Commands
{
    public class CommandBase
    {
        public CommandBase(Entity entity)
        {
            Entity = entity;
        }

        protected Entity Entity;
        protected Error Errors => Entity.Errors;
    }
}