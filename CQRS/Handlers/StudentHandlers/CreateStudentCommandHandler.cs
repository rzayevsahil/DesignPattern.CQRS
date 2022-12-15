using System.Threading;
using System.Threading.Tasks;
using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.StudentCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;
using MediatR;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.StudentHandlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly Context _context;
        public CreateStudentCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
