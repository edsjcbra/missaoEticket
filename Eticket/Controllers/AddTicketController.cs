using Domain.Contracts.UserCase.AddTicket;
using Domain.Entities;
using Eticket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTicketController : ControllerBase
    {
        private readonly IAddTicketUserCase _addTicketUserCase;
        public AddTicketController(IAddTicketUserCase addTicketUserCase)
        {
            _addTicketUserCase = addTicketUserCase;
        }
        [HttpPost]
        public IActionResult AddTicket(AddTicketInput input)
        {
            var ticket = new Ticket(input.Origin, input.Destination, input.Price, input.TravelDate);

            _addTicketUserCase.AddTicket(ticket);
            return Created("", ticket);
        }
    }
}
