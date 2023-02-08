namespace Eticket.Models
{
    public class AddTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double  Price { get; set; }
        public DateTime TravelDate { get; set; }
    }
}
