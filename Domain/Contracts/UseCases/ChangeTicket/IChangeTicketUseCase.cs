using Domain.Entities;

namespace Domain.Contracts.UseCases.ChangeTicket
{
    public interface IChangeTicketUseCase
    {
        void ChangeTicket(int id, Ticket ticket);
    }
}
