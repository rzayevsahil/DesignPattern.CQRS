using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.PersonCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;
using System;
using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class CreateUniversityHandler
    {
        private readonly Context _context;
        public CreateUniversityHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateUniversityCommand createUniversityCommand)
        {
            _context.Universities.Add(new University
            {
                Name = createUniversityCommand.Name,
                Population = createUniversityCommand.Population,
            });
            _context.SaveChanges();
        }
    }
}
