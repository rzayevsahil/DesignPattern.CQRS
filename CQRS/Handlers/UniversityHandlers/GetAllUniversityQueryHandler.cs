using System.Collections.Generic;
using System.Linq;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class GetAllUniversityQueryHandler
    {
        private readonly Context _context;
        public GetAllUniversityQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllUniversityQueryResult> Handle(GetAllUniversityQuery getAllUniversityQuery)
        {
            var values = _context.Universities.Select(x => new GetAllUniversityQueryResult()
            {
                UniversityID = x.UniversityID,
                Name = x.Name,
                City = x.City
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
