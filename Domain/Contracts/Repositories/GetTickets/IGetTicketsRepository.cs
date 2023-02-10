using Domain.Entities;

namespace Domain.Contracts.Repositories.GetTickets
{
    public interface IGetTicketsRepository
    {
        List<Ticket> GetTickets();
    }
}
