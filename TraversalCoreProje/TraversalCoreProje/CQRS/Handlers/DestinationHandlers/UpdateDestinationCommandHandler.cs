using DataAcessLayer.Concrete;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public  void Handle (UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.Destinationid);
            values.City = command.CİTY;
            values.DayNight = command.Daynight;
            values.Price = (double)command.price;
            _context.SaveChanges();

        }
    }

     
}
