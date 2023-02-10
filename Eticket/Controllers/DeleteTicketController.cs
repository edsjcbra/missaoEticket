using Domain.Contracts.UseCases.DeleteTicket;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]/{id:int}")]
    [ApiController]
    public class DeleteTicketController : ControllerBase
    {
        private readonly IDeleteTicketUseCase _iDeleteTicketUseCase;

        public DeleteTicketController(IDeleteTicketUseCase iDeleteTicketUseCase)
        {
            _iDeleteTicketUseCase = iDeleteTicketUseCase;
        }

        [HttpDelete]
        public IActionResult DeleteTicket([FromRoute] int id)
        {
            _iDeleteTicketUseCase.DeleteTicket(id);
            return Ok();
        }
    }
}
