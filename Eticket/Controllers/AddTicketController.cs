using Domain.Contracts.UseCases.AddTicket;
using Domain.Entities;
using Eticket.Models;
using Eticket.Models.Error;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eticket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddTicketController : ControllerBase
    {
        private readonly IAddTicketUseCase _addTicketUserCase;
        private readonly IValidator<AddTicketInput> _addTicketInputValidator;

        public AddTicketController(IAddTicketUseCase addTicketUserCase, IValidator<AddTicketInput> addTicketInputValidator)
        {
            _addTicketUserCase = addTicketUserCase;
            _addTicketInputValidator = addTicketInputValidator;
        }
        [HttpPost]
        public IActionResult AddTicket(AddTicketInput input)
        {
                
            var validationResult = _addTicketInputValidator.Validate(input);

            if(!validationResult.IsValid) 
            {
                return BadRequest(validationResult.Errors.ToCustomValidatorFailure());
            }

            var ticket = new Ticket(input.Origin, input.Destination, input.Price, input.TravelDate);

            _addTicketUserCase.AddTicket(ticket);
            return Created("", ticket);
        }
    }
}
