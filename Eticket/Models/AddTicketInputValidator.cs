using FluentValidation;

namespace Eticket.Models
{
    public class AddTicketInputValidator : AbstractValidator<AddTicketInput>
    {
        public AddTicketInputValidator()
        {
            RuleFor(t => t.Origin).NotEmpty();
            RuleFor(t => t.Destination).NotEmpty();
            RuleFor(t => t.Price).NotEmpty();
            RuleFor(t => t.TravelDate).NotEmpty();
        }
    }
}
