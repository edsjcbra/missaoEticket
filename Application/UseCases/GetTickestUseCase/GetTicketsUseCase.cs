using Domain.Contracts.Repositories.GetTickets;
using Domain.Contracts.UseCases.GetTickets;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.GetTicketsUseCase
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
