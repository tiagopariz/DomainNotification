using DomainNotification.Domain.Entities;
using DomainNotification.Domain.Errors;

namespace DomainNotification.Domain.Commands
{
    public class SavePerson : Command
    {
        private readonly Person _person;

        public SavePerson(Person person) : base(person)
        {
            _person = person;
            var description = new ErrorDescription("New person create on memory.", Level.Warning);
            _person.Errors.Add(description);
        }

        public void Run()
        {
            if (!Errors.HasErrors)
            {
                SavePersonInBackendSystems();
            }
            else
            {
                var error = new ErrorDescription("Registration not saved.", Level.Error);
                _person.Errors.Add(error);
            }
        }

        private void SavePersonInBackendSystems()
        {
            var message = new ErrorDescription("Registration succeeded.", Level.Information);
            _person.Errors.Add(message);
        }
    }
}