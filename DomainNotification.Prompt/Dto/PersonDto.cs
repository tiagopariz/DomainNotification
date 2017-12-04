using System;

namespace DomainNotification.Prompt.Dto
{
    public class PersonDto
    {
        public PersonDto(Guid personId, string name, string email)
        {
            PersonId = personId;
            Name = name;
            Email = email;
        }

        public Guid PersonId { get; }
        public string Name { get; }
        public string Email { get; }
    }
}
