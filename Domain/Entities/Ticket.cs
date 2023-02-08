using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        public Ticket(string origin, string destination, double price, DateTime travelDate)
        {
            Origin = origin;
            Destination = destination;
            Price = price;
            TravelDate = travelDate;
        }

        public string Origin { get; private set; }
        public string Destination { get; private set; }
        public double Price { get; private set; }
        public DateTime TravelDate { get; private set; }
    }
}
