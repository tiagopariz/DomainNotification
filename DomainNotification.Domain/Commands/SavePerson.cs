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
            var description = new ErrorDescription("New person create on memory.", new Warning());
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
                var error = new ErrorDescription("Registration not saved.", new Critical());
                _person.Errors.Add(error);
            }
        }

        private void SavePersonInBackendSystems()
        {
            var message = new ErrorDescription("Registration succeeded.", new Information());
            _person.Errors.Add(message);
        }
    }
}