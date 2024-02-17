using MediatR;

namespace ECommerce_Example.Features.Queries.Product
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public int Id { get; set; }
    }
}
