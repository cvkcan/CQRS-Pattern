using MediatR;

namespace ECommerce_Example.Features.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {
            //Do Something()

            bool succeed = false;
            if (succeed)
            {
                return new LoginSuccessCommandResponse()
                {
                    Message = ""
                };
            }
            throw new Exception("Error!!");
        }
    }
}
