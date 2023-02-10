using Domain.Contracts.Repositories.GetTicket;
using Domain.Entities;
using Infra.Repository.DbContexts;

namespace Infra.Repository.Repositories.GetTicket
{
    public class GetTicketByIdRepository : IGetTicketByIdRepository
    {
        private readonly EticketDbContext _dbContext;

        public GetTicketByIdRepository(EticketDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Ticket GetTicket(int id)
        {
            var ticket = _dbContext.Tickets.FirstOrDefault(x => x.Id == id);

            if (ticket!= null)
            {
                return ticket;
            }
            else
            {
                throw new Exception("05X04 - Ticket nao encontrado na base de dados");
            }
        }
    }
}
