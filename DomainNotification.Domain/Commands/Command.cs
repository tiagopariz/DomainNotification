using DomainNotification.Domain.Entities;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.Commands
{
    public abstract class Command
    {
        protected Command(Entity entity)
        {
            Entity = entity;
        }

        protected Entity Entity;
        protected Error Errors => Entity.Errors;
    }
}