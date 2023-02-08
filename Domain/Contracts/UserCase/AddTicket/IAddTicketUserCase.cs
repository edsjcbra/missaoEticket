using Domain.Entities;

namespace Domain.Contracts.UserCase.AddTicket
{
    public interface IAddTicketUserCase
    {
        void AddTicket(Ticket ticket);
    }
}
