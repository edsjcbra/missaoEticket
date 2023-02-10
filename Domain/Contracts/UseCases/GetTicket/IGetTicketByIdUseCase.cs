using Domain.Entities;

namespace Domain.Contracts.UseCases.GetTicket
{
    public interface IGetTicketByIdUseCase
    {
        Ticket GetTicket(int id);
    }
}
