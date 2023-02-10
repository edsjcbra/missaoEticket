using Domain.Contracts.Repositories.DeleteTicket;
using Infra.Repository.DbContexts;

namespace Infra.Repository.Repositories.DeleteTicket
{
    public class DeleteTicketRepository : IDeleteTicketRepository
    {
        private readonly EticketDbContext _dbContext;

        public DeleteTicketRepository(EticketDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool DeleteTicket(int id)
        {
            var ticketToDelete = _dbContext.Tickets.FirstOrDefault(t => t.Id == id);

            if (ticketToDelete == null) throw new Exception("Cadastro nao encontrado no banco de dados");

            _dbContext.Tickets.Remove(ticketToDelete);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
