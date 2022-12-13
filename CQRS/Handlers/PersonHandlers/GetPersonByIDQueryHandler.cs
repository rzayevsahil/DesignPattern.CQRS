using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.PersonQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.PersonResult;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers
{
    public class GetPersonByIDQueryHandler
    {
        private readonly Context _context;
        public GetPersonByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetPersonByIDQueryResult Handle(GetPersonByIDQuery getPersonByIdQuery)
        {
            var values = _context.Set<Person>().Find(getPersonByIdQuery.Id);
            return new GetPersonByIDQueryResult()
            {
                PersonID = values.PersonID,
                Name = values.Name,
                Surname = values.Surname
            };
        }
    }
}
