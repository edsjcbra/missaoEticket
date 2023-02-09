using Domain.Entities;
using Domain.Contracts.Repositories.AddTicket;
using Infra.Repository.DbContexts;
using Dapper;

namespace Infra.Repository.Repositories.AddTicket
{
    public class AddTicketRepository : IAddTicketRepository
    {
        private readonly EticketDbContext _dbContext;

        public AddTicketRepository(EticketDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddTicket(Ticket ticket)
        {
            _dbContext.Tickets.Add(ticket);
            _dbContext.SaveChanges();
        }
    }
}
