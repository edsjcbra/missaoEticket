using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Repository.Mappings
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            // Tabela
            builder.ToTable("ticket");

            // Chave Primária
            builder.HasKey(x => x.Id);

            // Identity
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            // Propriedades
            builder.Property(x => x.Origin)
                .IsRequired()
                .HasColumnName("origin")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(250);

            builder.Property(x => x.Destination)
                .IsRequired()
                .HasColumnName("destination")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(250);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnName("price")
                .HasColumnType("FLOAT");

            builder.Property(x => x.TravelDate)
                .IsRequired()
                .HasColumnName("date")
                .HasColumnType("SMALLDATETIME");
        }
    }
}