using Domain.Contracts.Repositories.DeleteTicket;
using Domain.Contracts.UseCases.DeleteTicket;

namespace Application.UseCases.DeleteTicket
{
    public class DeleteTicketUseCase : IDeleteTicketUseCase
    {
        private readonly IDeleteTicketRepository _ideleteTicketRepository;

        public DeleteTicketUseCase(IDeleteTicketRepository ideleteTicketRepository)
        {
            _ideleteTicketRepository = ideleteTicketRepository;
        }

        public bool DeleteTicket(int id)
        {
            _ideleteTicketRepository.DeleteTicket(id);
            return true;
        }
    }
}
