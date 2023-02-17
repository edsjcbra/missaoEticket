
using Application.UseCases.AddTicket;
using Application.UseCases.ChangeTicket;
using Application.UseCases.DeleteTicket;
using Application.UseCases.GetTicket;
using Application.UseCases.GetTickets;
using Domain.Contracts.Repositories.AddTicket;
using Domain.Contracts.Repositories.ChangeTicket;
using Domain.Contracts.Repositories.DeleteTicket;
using Domain.Contracts.Repositories.GetTicket;
using Domain.Contracts.Repositories.GetTickets;
using Domain.Contracts.UseCases.AddTicket;
using Domain.Contracts.UseCases.ChangeTicket;
using Domain.Contracts.UseCases.DeleteTicket;
using Domain.Contracts.UseCases.GetTicket;
using Domain.Contracts.UseCases.GetTickets;
using Domain.Entities;
using Eticket.Models;
using FluentValidation;
using Infra.Repository.DbContexts;
using Infra.Repository.Repositories.AddTicket;
using Infra.Repository.Repositories.ChangeTicket;
using Infra.Repository.Repositories.DeleteTicket;
using Infra.Repository.Repositories.GetTicket;
using Infra.Repository.Repositories.GetTickets;

namespace Eticket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<EticketDbContext>();
            builder.Services.AddScoped<IAddTicketRepository, AddTicketRepository>(); 
            builder.Services.AddScoped<IAddTicketUseCase, AddTicketUseCase>();
            builder.Services.AddScoped<IGetTicketsRepository, GetTicketsRepository>();
            builder.Services.AddScoped<IGetTicketsUseCase, GetTicketsUseCase>();
            builder.Services.AddScoped<IDeleteTicketRepository, DeleteTicketRepository>();
            builder.Services.AddScoped<IDeleteTicketUseCase, DeleteTicketUseCase>();
            builder.Services.AddScoped<IGetTicketByIdRepository, GetTicketByIdRepository>();
            builder.Services.AddScoped<IGetTicketByIdUseCase, GetTicketByIdUseCase>();
            builder.Services.AddScoped<IChangeTicketRepository, ChangeTicketRepository>();
            builder.Services.AddScoped<IChangeTicketUseCase, ChangeTicketUseCase>();
            builder.Services.AddTransient<IValidator<AddTicketInput>, AddTicketInputValidator>();
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}