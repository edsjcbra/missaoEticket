using Domain.Entities;

namespace Domain.Contracts.Repositories.ChangeTicket
{
    public interface IChangeTicketRepository
    {
        public void ChangeTicket(int id, Ticket ticket);
    }
}
