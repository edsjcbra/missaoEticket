using Domain.Contracts.UseCases.GetTicket;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTicketByIdController : ControllerBase
    {
        private readonly IGetTicketByIdUseCase _iGetTicketByIdUseCase;

        public GetTicketByIdController(IGetTicketByIdUseCase iGetTicketByIdUseCase)
        {
            _iGetTicketByIdUseCase = iGetTicketByIdUseCase;
        }

        [HttpGet]
        public IActionResult GetTicket(int id)
        {
            var ticket = _iGetTicketByIdUseCase.GetTicket(id);

            return Created("", ticket);
        }
    }
}
