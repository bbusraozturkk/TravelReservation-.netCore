using DataAccess_layer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TravelReservation.CQRS.Results.DestinationResults;

namespace TravelReservation.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                price = (float)x.Price
            }).AsNoTracking().ToList(); //AsNoTracking(): Okuma işlemlerinde değişiklik izleme (change tracking) kapatılarak performans artırılıyor.

            return values;
        }
    }
}
