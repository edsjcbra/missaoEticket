using Domain.Entities;

namespace Domain.Contracts.Repositories.DeleteTicket
{
    public interface IDeleteTicketRepository
    {
        void DeleteTicket(int id);
    }
}
