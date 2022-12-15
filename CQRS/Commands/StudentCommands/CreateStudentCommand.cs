using MediatR;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Commands.StudentCommands
{
    public class CreateStudentCommand : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Status { get; set; }
    }
}
