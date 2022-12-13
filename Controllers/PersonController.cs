using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers;
using DesignPattern.CQRS.PresentationLayer.CQRS.Queries.PersonQueries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.PresentationLayer.Controllers
{
    public class PersonController : Controller
    {
        private readonly GetPersonHumanResourceQueryHandler _getPersonHumanResourceQueryHandler;
        private readonly GetPersonByIDQueryHandler _getPersonByIDQueryHandler;
        private readonly CreatePersonHandler _createPersonHandler;
        public PersonController(GetPersonHumanResourceQueryHandler getPersonHumanResourceQueryHandler, GetPersonByIDQueryHandler getPersonByIdQueryHandler, CreatePersonHandler createPersonHandler)
        {
            _getPersonHumanResourceQueryHandler = getPersonHumanResourceQueryHandler;
            _getPersonByIDQueryHandler = getPersonByIdQueryHandler;
            _createPersonHandler = createPersonHandler;
        }

        public IActionResult Index()
        {
            var values = _getPersonHumanResourceQueryHandler.Handle(new GetPersonHumanResourceQuery());
            return View(values);
        }

        public IActionResult GetPerson(int id)
        {
            var values = _getPersonByIDQueryHandler.Handle(new GetPersonByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(CreatePersonCommand createPersonCommand)
        {
            _createPersonHandler.Handle(createPersonCommand);
            return RedirectToAction("Index");
        }
    }
}
