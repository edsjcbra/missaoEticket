using Domain.Entities;

namespace Domain.Contracts.Repositories.GetTicket
{
    public interface IGetTicketByIdRepository
    {
        Ticket GetTicket(int id);
    }
}
