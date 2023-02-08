using Domain.Entities;
using Domain.Contracts.Repositories.AddTicket;
using Infra.Repository.DbContext;
using Dapper;

namespace Infra.Repository.Repositories.AddTicket
{
    public class AddTicketRepository : IAddTicketRepository
    {
        private readonly IDbContext _dbContext;

        public AddTicketRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddTicket(Ticket ticket)
        {
            var query = "INSERT INTO ticket(origin, destination, price, date) VALUES(@origin, @destination, @price, @date) ";
            var parameters = new DynamicParameters();
            parameters.Add("origin", ticket.Origin, System.Data.DbType.String);
            parameters.Add("destination", ticket.Destination, System.Data.DbType.String);
            parameters.Add("price", ticket.Price, System.Data.DbType.Decimal);
            parameters.Add("date", ticket.TravelDate, System.Data.DbType.DateTime);

            using var connection = _dbContext.CreateConnection();

            connection.Execute(query, parameters);
        }
    }
}
