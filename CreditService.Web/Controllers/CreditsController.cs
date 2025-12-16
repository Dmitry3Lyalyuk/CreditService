using CreditService.Application.Credits.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CreditService.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CreditsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<CreditDTO>>> GetAllCredits()
        {
            var query = new GetAllCreditsQuery();
            var creadits = await _mediator.Send(query);

            if (creadits is null or [])
            {
                return NotFound("No credits found!");
            }

            return Ok(creadits);
        }
    }
}
