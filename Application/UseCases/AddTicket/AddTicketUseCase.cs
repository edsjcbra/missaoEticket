using Domain.Contracts.Repositories.AddTicket;
using Domain.Contracts.UseCases.AddTicket;
using Domain.Entities;

namespace Application.UseCases.AddTicket
{
    public class AddTicketUseCase : IAddTicketUseCase
    {
        private readonly IAddTicketRepository _addTicketRepository;
        public AddTicketUseCase(IAddTicketRepository addTicketRepository)
        {
            _addTicketRepository = addTicketRepository;
        }

        public void AddTicket(Ticket ticket)
        {

            _addTicketRepository.AddTicket(ticket);
        }
    }
}
