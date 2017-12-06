using DomainNotification.Domain.Entities;
using DomainNotification.Domain.Notifications;

namespace DomainNotification.Domain.Commands
{
    public class SavePerson : CommandBase
    {
        private readonly Person _person;

        public SavePerson(Person person) : base(person)
        {
            _person = person;
            var warning = new Warning("New person create on memory.");
            _person.Notification.Warnings.Add(warning);
        }

        public void Run()
        {
            if (!Notification.HasErrors)
            {
                SavePersonInBackendSystems();
            }
            else
            {
                var error = new Error("Registration not saved.");
                _person.Notification.Errors.Add(error);
            }
            
        }

        private void SavePersonInBackendSystems()
        {
            var message = new Message("Registration succeeded.");
            _person.Notification.Messages.Add(message);
        }
    }
}