using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityByIDQueryHandler
    {
        private readonly Context _context;
        public GetUniversityByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetUniversityByIDQueryResult Handle(GetUniversityByIDQuery getUniversityByIdQuery)
        {
            var values = _context.Set<University>().Find(getUniversityByIdQuery.Id);
            return new GetUniversityByIDQueryResult
            {
                UniversityID = values.UniversityID,
                Name = values.Name,
                Population = values.Population
            };
        }
    }
}
