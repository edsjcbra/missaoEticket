
using Application.UseCases.AddTicket;
using Domain.Contracts.Repositories.AddTicket;
using Domain.Contracts.UseCases.AddTicket;
using Eticket.Models;
using FluentValidation;
using Infra.Repository.Repositories.AddTicket;

namespace Eticket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IAddTicketRepository, AddTicketRepository>(); 
            builder.Services.AddScoped<IAddTicketUseCase, AddTicketUseCase>();
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