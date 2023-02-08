using Eticket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTicketController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddTicket(AddTicketInput input)
        {

            return Created("", input);
        }
    }
}
