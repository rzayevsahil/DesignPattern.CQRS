using System.Collections.Generic;
using System.Linq;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers
{
    public class GetProductProducerQueryHandler
    {
        private readonly Context _context;
        public GetProductProducerQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductProducerQueryResult> Handle(GetProductProducerQuery getProductProducerQuery)
        {
            var values = _context.Products.Select(x => new GetProductProducerQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                ProductStatus = x.ProductStatus,
                ProductStorage = x.ProductStorage,
            }).AsNoTracking().ToList();

            return values;
        }
    }
}
