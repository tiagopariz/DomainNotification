using System;
using DomainNotification.Application.Services;
using DomainNotification.Prompt.Dto;

namespace DomainNotification.Prompt
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Type your name");
            var name = Console.ReadLine();
            Console.WriteLine("Type your E-mail");
            var email = Console.ReadLine();

            var personDto = new PersonDto(Guid.NewGuid(), name, email);
            var personService = new PersonService(personDto.PersonId, personDto.Name, personDto.Email);

            Submit(personService, personDto);
            Console.ReadKey();
        }

        public static void Submit(PersonService personService, PersonDto personDto)
        {
            personService.SavePerson(personDto.PersonId,
                                     personDto.Name);

            if (personService.HasNotifications())
                ShowNotifications(personService);
        }

        private static void ShowNotifications(PersonService personService)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nErrors\n");

            foreach (var error in personService.Errors())
            {
                Console.WriteLine(error.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWarnings\n");

            foreach (var error in personService.Warnings())
            {
                Console.WriteLine(error.ToString());
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nMessages\n");

            foreach (var error in personService.Messages())
            {
                Console.WriteLine(error.ToString());
            }
        }
    }
}
