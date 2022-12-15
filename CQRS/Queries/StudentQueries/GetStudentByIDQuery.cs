using DesignPattern.CQRS.PresentationLayer.CQRS.Results.StudentResult;
using MediatR;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Queries.StudentQueries
{
    public class GetStudentByIDQuery : IRequest<GetStudentByIDQueryResult>
    {
        public GetStudentByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
