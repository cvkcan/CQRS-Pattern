namespace ECommerce_Example.Features.Commands.Login
{
    public class LoginCommandResponse
    {
    }
    public class LoginSuccessCommandResponse : LoginCommandResponse
    {
        public string Message { get; set; }
    }
}
