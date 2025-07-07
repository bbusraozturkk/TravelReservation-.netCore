using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using System.Collections.Generic;
using TravelReservation.CQRS.Results.GuideResults;

namespace TravelReservation.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
