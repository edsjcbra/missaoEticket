namespace Domain.Entities
{
    public class Ticket
    {
        public Ticket(string origin, string destination, float price, DateTime travelDate)
        {
            Origin = origin;
            Destination = destination;
            Price = price;
            TravelDate = travelDate;
        }

        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public float Price { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
