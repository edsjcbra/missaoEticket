using Domain.Contracts.Repositories.GetTickets;
using Domain.Entities;
using Infra.Repository.DbContexts;

namespace Infra.Repository.Repositories.GetTickets
{
    public class GetTicketsRepository : IGetTicketsRepository
    {
        
        private readonly EticketDbContext _dbContext;

        public GetTicketsRepository(EticketDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ticket> GetTickets()
        {
            return _dbContext.Tickets.ToList();
        }
    }
}

