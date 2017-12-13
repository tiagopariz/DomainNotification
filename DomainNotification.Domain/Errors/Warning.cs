using DomainNotification.Domain.Interfaces.Errors;

namespace DomainNotification.Domain.Errors
{
    public class Warning : ILevel
    {
        public Warning(string description = "Warning")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString()
        {
            return Description;
        }
    }
}