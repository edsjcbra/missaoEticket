using Application.UseCases.ChangeTicket;
using Domain.Contracts.Repositories.ChangeTicket;
using Domain.Contracts.UseCases.ChangeTicket;
using Moq;
using UnitTests.Shared.Fakers;

namespace UnitTests.Application.UseCases.ChangeTicket
{
    public class ChangeTicketUseCaseTests
    {
        private readonly Mock<IChangeTicketRepository> _changeTicketRepositoryMock;
        private readonly IChangeTicketUseCase _sut;

        public ChangeTicketUseCaseTests()
        {
            _changeTicketRepositoryMock = new Mock<IChangeTicketRepository>();
            _sut = new ChangeTicketUseCase(_changeTicketRepositoryMock.Object);
        }

        [Fact]
        public void ShouldChangeTicket()
        {
            // Arrange
            const int id = 1;
            var ticket = TicketFaker.Create();

            // Act
            _sut.ChangeTicket(id, ticket);

            // Assert
            _changeTicketRepositoryMock.Verify(mock => mock.ChangeTicket(id, ticket), Times.Once);
        }

        [Fact]
        public void ShouldThrowArgumentException()
        {
            // Arrange
            const int id = 0;
            var ticket = TicketFaker.Create();

            // Act && Assert
            Assert.Throws<ArgumentException>(() => _sut.ChangeTicket(id, ticket));
        }
    }
}
