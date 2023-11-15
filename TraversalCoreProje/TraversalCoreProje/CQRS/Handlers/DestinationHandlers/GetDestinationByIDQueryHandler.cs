using DataAcessLayer.Concrete;
using TraversalCoreProje.CQRS.Querises.DestinationQueris;
using TraversalCoreProje.CQRS.Result.DestinationResult;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                Destinationid = values.DestinationID,
                CİTY = values.City,
                Daynight = values.DayNight,
                Price = values.Price

            };

        }
    }
}
