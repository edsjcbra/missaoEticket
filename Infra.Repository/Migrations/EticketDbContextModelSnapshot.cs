// <auto-generated />
using System;
using Infra.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Repository.Migrations
{
    [DbContext(typeof(EticketDbContext))]
    partial class EticketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("destination");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("origin");

                    b.Property<double>("Price")
                        .HasColumnType("FLOAT")
                        .HasColumnName("price");

                    b.Property<DateTime>("TravelDate")
                        .HasColumnType("SMALLDATETIME")
                        .HasColumnName("date");

                    b.HasKey("Id");

                    b.ToTable("ticket", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
