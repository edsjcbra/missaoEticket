using Domain.Entities;

namespace UnitTests.Shared.Fakers
{
    internal static class TicketFaker
    {
        public static Ticket Create()
        {
            return new Ticket("any_origin", "any_destination", 10.45f, DateTime.Now);
        }
    }
}