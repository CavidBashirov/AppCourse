using FluentValidation;

namespace Service.DTOs.Account
{
    public class LoginDto
    {
        public string EmailOrUsername { get; set; }
        public string Password { get; set; }
    }

    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(x => x.EmailOrUsername).NotEmpty().WithMessage("Username or email is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
        }
    }
}
