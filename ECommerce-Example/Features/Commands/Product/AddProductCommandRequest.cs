using MediatR;

namespace ECommerce_Example.Features.Commands.Product
{
    public class AddProductCommandRequest : IRequest<AddProductCommandResponse>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
