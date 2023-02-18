using Domain.Entities;

namespace UnitTests.Domain.Entities
{
    public class TicketTests
    {
        [Fact(DisplayName = "Should construct ticket entity correctly")]
        public void ShouldConstructCorrectly()
        {
            // Arrange
            const string origin = "any_origin";
            const string destination = "any_destination";
            const float price = 10.54f;
            var travelDate = DateTime.Now;

            // Act
            var ticket = new Ticket(origin, destination, price, travelDate);

            // Assert
            ticket.Origin.Equals(origin);
            ticket.Destination.Equals(destination);
            ticket.Price.Equals(price);
            ticket.TravelDate.Equals(travelDate);
        }
    }
}