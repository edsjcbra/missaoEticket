using Domain.Contracts.Repositories.ChangeTicket;
using Domain.Entities;
using Infra.Repository.DbContexts;

namespace Infra.Repository.Repositories.ChangeTicket
{
    public class ChangeTicketRepository : IChangeTicketRepository
    {
        private readonly EticketDbContext _dbContext;

        public ChangeTicketRepository(EticketDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public void ChangeTicket(int id, Ticket newTicket)
        {
            var ticketToChange = _dbContext.Tickets.FirstOrDefault(t => t.Id == id);
            if (ticketToChange != null)
            {
                ticketToChange.Origin = newTicket.Origin;
                ticketToChange.Destination = newTicket.Destination;
                ticketToChange.Price = newTicket.Price;
                ticketToChange.TravelDate = newTicket.TravelDate;

                _dbContext.Tickets.Update(ticketToChange);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("05X04 - Ticket nao encontrado na base de dados");
            }

        }
    }
}
