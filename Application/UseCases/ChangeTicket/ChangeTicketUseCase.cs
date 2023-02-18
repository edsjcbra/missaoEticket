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
            if (id <= 0)
            {
                throw new ArgumentException("Id should be greather than zero", nameof(id));
            }

            _iChangeTicketrepository.ChangeTicket(id, ticket);
        }
    }
}
