using Application.UseCases.AddTicket;
using Application.UseCases.DeleteTicket;
using Application.UseCases.GetTicket;
using Application.UseCases.GetTickets;
using Domain.Contracts.Repositories.AddTicket;
using Domain.Contracts.Repositories.DeleteTicket;
using Domain.Contracts.Repositories.GetTicket;
using Domain.Contracts.Repositories.GetTickets;
using Domain.Contracts.UseCases.AddTicket;
using Domain.Contracts.UseCases.DeleteTicket;
using Domain.Contracts.UseCases.GetTicket;
using Domain.Contracts.UseCases.GetTickets;
using Domain.Entities;
using Moq;

namespace UnitTests
{
    public class UnitTests
    {
        private readonly Mock<IAddTicketRepository> _addRepository;
        private readonly Mock<IGetTicketsRepository> _getTicketsRepository;
        private readonly Mock<IGetTicketByIdRepository> _getTicketByIdRepository;
        private readonly Mock<IDeleteTicketRepository> _deleteTicketRepository;
        private readonly IAddTicketUseCase _addTicketTest;
        private readonly IGetTicketsUseCase _getTicketsTest;
        private readonly IGetTicketByIdUseCase _getTicketByIdTest;
        private readonly IDeleteTicketUseCase _deleteTicketTest;

        public UnitTests()
        {
            _addRepository = new Mock<IAddTicketRepository>();
            _getTicketsRepository = new Mock<IGetTicketsRepository>();
            _getTicketByIdRepository = new Mock<IGetTicketByIdRepository>();
            _deleteTicketRepository = new Mock<IDeleteTicketRepository>();
            _addTicketTest = new AddTicketUseCase(_addRepository.Object);
            _getTicketsTest = new GetTicketsUseCase(_getTicketsRepository.Object);
            _getTicketByIdTest = new GetTicketByIdUseCase(_getTicketByIdRepository.Object);
            _deleteTicketTest = new DeleteTicketUseCase(_deleteTicketRepository.Object);
        }

        [Fact(DisplayName = "AddTicket deve adicionar um Ticket na base de dados")]
        public void AddTicket()
        {
            var ticketTest = new Ticket("Teste", "Teste", 1, DateTime.Now);

            _addTicketTest.AddTicket(ticketTest);

            _addRepository.Verify(m => m.AddTicket(ticketTest), Times.Once());
        }

        [Fact(DisplayName = "GetTickets deve listar todos Tickets da base de dados")]
        public void GetTickets()
        {
            _getTicketsTest.GetTickets();

            _getTicketsRepository.Verify(m => m.GetTickets(), Times.Once());
        }

        [Fact(DisplayName = "GetTicket deve listar um Ticket especifico da base de dados")]
        public void GetTicketById()
        {
            _getTicketByIdTest.GetTicket(1);

            _getTicketByIdRepository.Verify(m => m.GetTicket(1), Times.Once());
        }

        [Fact(DisplayName = "DeleteTicket deve deletar um Ticket especifico da base de dados")]
        public void DeleteTicket()
        {
            _deleteTicketTest.DeleteTicket(1);

            _deleteTicketRepository.Verify(m => m.DeleteTicket(1), Times.Once());
        }
    }
}