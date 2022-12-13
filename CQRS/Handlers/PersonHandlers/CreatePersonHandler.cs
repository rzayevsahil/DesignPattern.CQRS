using System;
using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.PersonHandlers
{
    public class CreatePersonHandler
    {
        private readonly Context _context;
        public CreatePersonHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreatePersonCommand createPersonCommand)
        {
            _context.Persons.Add(new Person()
            {
                Name = createPersonCommand.Name,
                Surname = createPersonCommand.Surname,
                City = createPersonCommand.City,
                StartWork = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
