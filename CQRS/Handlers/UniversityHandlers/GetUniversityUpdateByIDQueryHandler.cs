using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class GetUniversityUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetUniversityUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetUniversityUpdateByIDQueryResult Handle(GetUniversityUpdateByIDQuery query)
        {
            var values = _context.Set<University>().Find(query.Id);
            return new GetUniversityUpdateByIDQueryResult
            {
                UniversityID = values.UniversityID,
                City = values.City,
                Country = values.Country,
                Name = values.Name,
                Population = values.Population,
                Region = values.Region
            };
        }
    }
}
