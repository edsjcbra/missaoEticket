using Domain.Entities;

namespace Domain.Contracts.UseCases.GetTickets
{
    public interface IGetTicketsUseCase
    {
        List<Ticket> GetTickets();
    }
}
