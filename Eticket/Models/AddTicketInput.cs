namespace Eticket.Models
{
    public class AddTicketInput
    {
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public float  Price { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
