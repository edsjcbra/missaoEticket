using Domain.Contracts.Repositories.GetTickets;
using Domain.Contracts.UseCases.GetTickets;
using Domain.Entities;

namespace Application.UseCases.GetTickets
{
    public class GetTicketsUseCase : IGetTicketsUseCase
    {
        private readonly IGetTicketsRepository _iGetTicketsRepository;
        public GetTicketsUseCase(IGetTicketsRepository iGetTicketsRepository) 
        {
            _iGetTicketsRepository = iGetTicketsRepository;
        }
        public List<Ticket> GetTickets()
        {
            return _iGetTicketsRepository.GetTickets();
        }
    }
}
