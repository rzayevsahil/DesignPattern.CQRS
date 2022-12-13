using DesignPattern.CQRS.PresentationLayer.CQRS.Handlers;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.PresentationLayer.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductProducerQueryHandler _getProductProducerQuery;
        private readonly GetProductPlannerQueryHandler _getProductPlannerQueryHandler;

        public ProductController(GetProductProducerQueryHandler getProductProducerQuery, GetProductPlannerQueryHandler getProductPlannerQueryHandler)
        {
            _getProductProducerQuery = getProductProducerQuery;
            _getProductPlannerQueryHandler = getProductPlannerQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductProducerQuery.Handle(new GetProductProducerQuery());
            return View(values);
        }

        public IActionResult PlannerProductList()
        {
            var values = _getProductPlannerQueryHandler.Handle(new GetProductPlannerQuery());
            return View(values);
        }
    }
}
