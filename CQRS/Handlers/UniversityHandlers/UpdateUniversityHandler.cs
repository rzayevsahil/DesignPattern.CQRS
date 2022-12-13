using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class UpdateUniversityHandler
    {
        private readonly Context _context;

        public UpdateUniversityHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateUniversityCommand updateUniversityCommand)
        {
            var values = _context.Universities.Find(updateUniversityCommand.UniversityID);
            values.City = updateUniversityCommand.City;
            values.Country = updateUniversityCommand.Country;
            values.Name = updateUniversityCommand.Name;
            values.Population = updateUniversityCommand.Population;
            values.Region = updateUniversityCommand.Region;
            _context.SaveChanges();
        }
    }
}
