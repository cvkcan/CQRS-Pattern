using MediatR;

namespace ECommerce_Example.Features.Commands.Product
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommandRequest, AddProductCommandResponse>
    {
        public async Task<AddProductCommandResponse> Handle(AddProductCommandRequest request, CancellationToken cancellationToken)
        {
            string ProductId = Guid.NewGuid().ToString();

            //Do Something()

            bool succeed = false;
            if (succeed)
            {
                //Do Something()
            }
            return new() { };
        }
    }
}
