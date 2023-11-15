using MediatR;
using TraversalCoreProje.CQRS.Result.GuideResult;

namespace TraversalCoreProje.CQRS.Querises.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
