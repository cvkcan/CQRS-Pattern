using MediatR;

namespace ECommerce_Example.Features.Queries.Product
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            //Do Something()

            bool succeed = false;
            if (succeed)
            {
                return new()
                {
                    Name = "Book",
                    Price = 1000,
                    Quantity = 5
                };
            }
            throw new Exception("Error!");
        }
    }
}
