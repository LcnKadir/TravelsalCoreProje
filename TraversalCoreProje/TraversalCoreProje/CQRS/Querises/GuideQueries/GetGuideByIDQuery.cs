using MediatR;
using TraversalCoreProje.CQRS.Result.GuideResult;

namespace TraversalCoreProje.CQRS.Querises.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
