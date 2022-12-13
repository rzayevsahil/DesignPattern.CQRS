using DesignPattern.CQRS.PresentationLayer.CQRS.Commands.UniversityCommands;
using DesignPattern.CQRS.PresentationLayer.DAL.Concrete;
using DesignPattern.CQRS.PresentationLayer.DAL.Entity;

namespace DesignPattern.CQRS.PresentationLayer.CQRS.Handlers.UniversityHandlers
{
    public class RemoveUniversityHandler
    {
        private readonly Context _context;
        public RemoveUniversityHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveUniversityCommand removeUniversityCommand)
        {
            var values = _context.Universities.Find(removeUniversityCommand.Id);
            _context.Universities.Remove(values);//bu ve aşağıdaki satır her ikisi aynı şey
            //_context.Remove(values); //bu satırda tablo ismini belirtmesek bile state durumundan otomatik olarak anlıyor
            _context.SaveChanges();
        }
    }
}
