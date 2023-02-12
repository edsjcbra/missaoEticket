using Domain.Contracts.Repositories.ChangeTicket;
using Domain.Contracts.UseCases.ChangeTicket;
using Domain.Entities;

namespace Application.UseCases.ChangeTicket
{
    public class ChangeTicketUseCase : IChangeTicketUseCase
    {
        private readonly IChangeTicketRepository _iChangeTicketrepository;

        public ChangeTicketUseCase(IChangeTicketRepository iChangeTicketrepository)
        {
            _iChangeTicketrepository = iChangeTicketrepository;
        }

        public void ChangeTicket(int id, Ticket ticket)
        {
            _iChangeTicketrepository.ChangeTicket(id, ticket);
        }
    }
}
