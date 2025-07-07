using DataAccess_layer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelReservation.CQRS.Queries.GuideQueries;
using TravelReservation.CQRS.Results.GuideResults;

namespace TravelReservation.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideID = x.GuideID,
                Description = x.Description,
                Image = x.Image,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
/*

AsNoTracking():

Ne İşe Yarar?
Değişiklik İzleme (Change Tracking): EF Core, varsayılan olarak veritabanından çektiği nesneleri izler. Eğer bu nesnelerde değişiklik yaparsanız, SaveChanges() çağrıldığında bu değişiklikleri veritabanına yansıtır.

AsNoTracking(): Bu izlemeyi devre dışı bırakır. Yani, çekilen nesneler "read-only" (salt okunur) olur ve değişiklikler takip edilmez.


Neden Kullanılır?
a) Performans Artışı
Change Tracking, EF Core'un bellek kullanımını artırır ve CPU zamanı harcar.

Örnek: 10.000 kayıt çekiyorsanız, EF Core her birini izlemeye çalışır. AsNoTracking() ile bu yük ortadan kalkar.

b) Özellikle Okuma (Read) İşlemlerinde
Sadece veri göstermek istediğinizde (örneğin, bir listeleme API'si), değişiklik izleme gereksizdir.

Senaryo: Bir e-ticaret sitesinde ürün listesi göstermek.

c) Yanlışlıkla Değişiklik Kaydetmeyi Önlemek
İzleme kapalıysa, nesnelerde yapılan değişiklikler SaveChanges() ile veritabanına gitmez.
 
 */