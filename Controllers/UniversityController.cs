using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.UniversityQueries;
using DesignPattern.CQRS.PresentationLayer.CQRS.Results.UniversityResult;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.PresentationLayer.Controllers
{
    public class UniversityController : Controller
    {
        private readonly GetAllUniversityQueryHandler _getAllUniversityQueryHandler;
        private readonly GetUniversityByIDQueryHandler _getUniversityByIdQueryHandler;
        private readonly CreateUniversityHandler _createUniversityHandler;
        private readonly RemoveUniversityHandler _removeUniversityHandler;
        private readonly GetUniversityUpdateByIDQueryHandler _getUniversityUpdateByIdQueryHandler;
        private readonly UpdateUniversityHandler _updateUniversityHandler;
        public UniversityController(GetAllUniversityQueryHandler getAllUniversityQueryHandler, GetUniversityByIDQueryHandler getUniversityByIdQueryHandler, CreateUniversityHandler createUniversityHandler, RemoveUniversityHandler removeUniversityHandler, GetUniversityUpdateByIDQueryHandler getUniversityUpdateByIdQueryHandler, UpdateUniversityHandler updateUniversityHandler)
        {
            _getAllUniversityQueryHandler = getAllUniversityQueryHandler;
            _getUniversityByIdQueryHandler = getUniversityByIdQueryHandler;
            _createUniversityHandler = createUniversityHandler;
            _removeUniversityHandler = removeUniversityHandler;
            _getUniversityUpdateByIdQueryHandler = getUniversityUpdateByIdQueryHandler;
            _updateUniversityHandler = updateUniversityHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllUniversityQueryHandler.Handle(new GetAllUniversityQuery());
            return View(values);
        }

        public IActionResult GetUniversity(int id)
        {
            var values = _getUniversityByIdQueryHandler.Handle(new GetUniversityByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddUniversity()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUniversity(CreateUniversityCommand createUniversityCommand)
        {
            _createUniversityHandler.Handle(createUniversityCommand);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteUniversity(int id)
        {
            _removeUniversityHandler.Handle(new RemoveUniversityCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateUniversity(int id)
        {
            var values = _getUniversityUpdateByIdQueryHandler.Handle(new GetUniversityUpdateByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateUniversity(UpdateUniversityCommand updateUniversityCommand)
        {
            _updateUniversityHandler.Handle(updateUniversityCommand);
            return RedirectToAction("Index");
        }
    }
}
