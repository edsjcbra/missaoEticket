using Domain.Entities;
using Domain.Contracts.Repositories.AddTicket;

namespace Infra.Repository.Repositories.AddTicket
{
    public class AddTicketRepository : IAddTicketRepository
    {
        private readonly List<Ticket> _tickets = new List<Ticket>();
        public void AddTicket(Ticket ticket)
        {
            _tickets.Add(ticket);
        }
    }
}
