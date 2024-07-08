using FluentValidation;
using Service.DTOs.Admin.Countries;
using System.ComponentModel.DataAnnotations;

namespace Service.DTOs.Account
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
    }

    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(x => x.Username).NotNull().WithMessage("Username is required");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email format is wrong").NotNull().WithMessage("Name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Password is required");

        }
    }
}
