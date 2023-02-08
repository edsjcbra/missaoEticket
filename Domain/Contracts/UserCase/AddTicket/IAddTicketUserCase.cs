using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.UserCase.AddTicket
{
    public interface IAddTicketUserCase
    {
        public void AddTicket(Ticket ticket);
    }
}
