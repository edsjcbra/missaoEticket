using Azure.Core;
using Domain.Contracts.Repositories.DeleteTicket;
using Domain.Entities;
using Infra.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Net;

namespace Infra.Repository.Repositories.DeleteTicket
{
    public class DeleteTicketRepository : IDeleteTicketRepository
    {
        private readonly EticketDbContext _dbContext;

        public DeleteTicketRepository(EticketDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteTicket(int id)
        {
            var ticketToDelete = _dbContext.Tickets.FirstOrDefault(t => t.Id == id);

            if (ticketToDelete != null)
            {
                _dbContext.Tickets.Remove(ticketToDelete);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new Exception("05X04 - Ticket nao encontrado na base de dados");
            }
        }
    }
}
