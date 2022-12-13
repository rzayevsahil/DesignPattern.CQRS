using System;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands
{
    public class CreatePersonCommand
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartWork { get; set; }
        public bool Status { get; set; }
    }
}
