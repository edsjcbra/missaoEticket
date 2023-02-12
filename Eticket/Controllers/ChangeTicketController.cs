using Domain.Contracts.UseCases.ChangeTicket;
using Domain.Entities;
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
        private readonly IValidator<Ticket> _changeTicketInputValidator;

        public ChangeTicketController(IChangeTicketUseCase changeTicketUserCase, IValidator<Ticket> changeTicketInputValidator)
        {
            _changeTicketUseCase = changeTicketUserCase;
            _changeTicketInputValidator = changeTicketInputValidator;
        }
        [HttpPut]
        public IActionResult Ticket([FromRoute] int id, [FromBody] Ticket input)
        {
                
            var validationResult = _changeTicketInputValidator.Validate(input);

            if(!validationResult.IsValid) 
            {
                return BadRequest(validationResult.Errors.ToCustomValidatorFailure());
            }

            _changeTicketUseCase.ChangeTicket(id, input);
            return Created("", input);
        }
    }
}
