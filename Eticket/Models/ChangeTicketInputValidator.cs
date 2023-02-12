using Domain.Entities;
using FluentValidation;

namespace Eticket.Models
{
    public class ChangeTicketInputValidator : AbstractValidator<Ticket>
    {
        public ChangeTicketInputValidator()
        {
            RuleFor(t => t.Origin).NotEmpty();
            RuleFor(t => t.Destination).NotEmpty();
            RuleFor(t => t.Price).NotEmpty();
            RuleFor(t => t.TravelDate).NotEmpty();
        }
    }

}
