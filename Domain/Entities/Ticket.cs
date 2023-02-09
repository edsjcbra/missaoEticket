using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id { get; private set; }
        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public float Price { get; private set; }
        public DateTime TravelDate { get; private set; }
    }
}
