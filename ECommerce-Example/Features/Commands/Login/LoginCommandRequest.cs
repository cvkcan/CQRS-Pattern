using MediatR;

namespace ECommerce_Example.Features.Commands.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
