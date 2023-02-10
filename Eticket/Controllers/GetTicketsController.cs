using Domain.Contracts.UseCases.GetTickets;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTicketsController : ControllerBase
    {
        private readonly IGetTicketsUseCase _iGetTicketUseCase;
        public GetTicketsController(IGetTicketsUseCase iGetTicketUseCase) 
        {
            _iGetTicketUseCase = iGetTicketUseCase;
        }

        [HttpGet]
        public IActionResult GetTickets()
        {
            var tickets = _iGetTicketUseCase.GetTickets();

            return Created("", tickets);
        }
    }
}
