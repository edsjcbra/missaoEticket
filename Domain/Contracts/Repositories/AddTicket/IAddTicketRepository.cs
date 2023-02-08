using Domain.Entities;

namespace Domain.Contracts.Repositories.AddTicket
{
    public interface IAddTicketRepository
    {
        void AddTicket(Ticket ticket);
    }
}
