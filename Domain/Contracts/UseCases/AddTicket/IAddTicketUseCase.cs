using Domain.Entities;

namespace Domain.Contracts.UseCases.AddTicket
{
    public interface IAddTicketUseCase
    {
        void AddTicket(Ticket ticket);
    }
}
