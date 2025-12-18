using CreditService.Application.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CreditService.Application.Credits.Queries
{
    public record GetAllCreditsQuery : IRequest<List<CreditDTO>>
    {

    }
    public class GetAllCreditsQueryHandler : IRequestHandler<GetAllCreditsQuery, List<CreditDTO>>
    {
        private readonly IApplicationDbContext _context;
        public GetAllCreditsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CreditDTO>> Handle(GetAllCreditsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Credits.Select(c => new CreditDTO
            {
                Number = c.Number,
                Amount = c.Amount,
                TermValue = c.TermValue,
                InterestValue = c.InterestValue,
                Status = c.Status,
                CreatedAt = c.CreatedAt,
                LastModifiedAt = c.LastModifiedAt

            }).ToListAsync(cancellationToken);
        }
    }
}
