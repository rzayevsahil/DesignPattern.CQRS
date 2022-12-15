using System.Collections.Generic;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.StudentResult;
using MediatR;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Queries.StudentQueries
{
    public class GetAllStudentQuery : IRequest<List<GetAllStudentQueryResult>>
    {
    }
}
