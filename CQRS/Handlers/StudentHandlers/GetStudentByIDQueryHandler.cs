using System.Threading;
using System.Threading.Tasks;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.StudentQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.StudentResult;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using MediatR;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.StudentHandlers
{
    public class GetStudentByIDQueryHandler:IRequestHandler<GetStudentByIDQuery,GetStudentByIDQueryResult>
    {
        private readonly Context _context;
        public GetStudentByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetStudentByIDQueryResult> Handle(GetStudentByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Students.FindAsync(request.Id);
            return new GetStudentByIDQueryResult
            {
                StudentID = values.StudentID,
                Name = values.Name,
                Surname = values.Surname,
                Mail = values.Mail
            };
        }
    }
}
