using Domain.Entities;
using Infra.Repository.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository.DbContexts
{
    public class EticketDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=digital_agency2;User Id=sa;Password=Pass@word;TrustServerCertificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TicketMap());
        }
    }
}
