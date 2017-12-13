using DomainNotification.Domain.Interfaces.Errors;

namespace DomainNotification.Domain.Errors
{
    public class Information : ILevel
    {
        public Information(string description = "Information")
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