using Domain.Contracts.UseCases.ChangeTicket;
using Domain.Entities;
using Eticket.Models;
using Eticket.Models.Error;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]/{id:int}")]
    [ApiController]
    public class ChangeTicketController : ControllerBase
    {
        private readonly IChangeTicketUseCase _changeTicketUseCase;
        private readonly IValidator<AddTicketInput> _addTicketInputValidator;

        public ChangeTicketController(IChangeTicketUseCase changeTicketUserCase, IValidator<AddTicketInput> addTicketInputValidator)
        {
            _changeTicketUseCase = changeTicketUserCase;
            _addTicketInputValidator = addTicketInputValidator;
        }
        [HttpPut]
        public IActionResult Ticket([FromRoute] int id, [FromBody] AddTicketInput input)
        {
                
            var validationResult = _addTicketInputValidator.Validate(input);

            if(!validationResult.IsValid) 
            {
                return BadRequest(validationResult.Errors.ToCustomValidatorFailure());
            }

            var ticketToChange = new Ticket(input.Origin, input.Destination, input.Price, input.TravelDate);

            _changeTicketUseCase.ChangeTicket(id, ticketToChange);

            return Created("", ticketToChange);
        }
    }
}
