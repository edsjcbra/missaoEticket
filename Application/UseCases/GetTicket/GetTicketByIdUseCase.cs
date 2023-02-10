using Domain.Contracts.Repositories.GetTicket;
using Domain.Contracts.UseCases.GetTicket;
using Domain.Entities;

namespace Application.UseCases.GetTicket
{
    public class GetTicketByIdUseCase : IGetTicketByIdUseCase
    {
        private readonly IGetTicketByIdRepository _iGetTicketByIdRepository;
        public GetTicketByIdUseCase(IGetTicketByIdRepository iGetTicketByIdRepository) 
        {
            _iGetTicketByIdRepository = iGetTicketByIdRepository;
        }
        public Ticket GetTicket(int id)
        {
            return _iGetTicketByIdRepository.GetTicket(id);
        }
    }
}
