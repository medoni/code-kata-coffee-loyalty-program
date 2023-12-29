using CLPService.Modules.Payment.UseCases.StampPayment.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CLPService.Modules.Payment.UseCases.StampPayment.Api;

/// <summary>
/// Manages payment for stamp
/// </summary>
[Route("api/v1/payment/coffee-stamps")]
[ApiController]
[Consumes("application/json")]
[Produces("application/json")]
[Tags("Payment")]
public class StampPaymentController
{
    /// <summary>
    /// Pays a coffee stamp
    /// </summary>
    /// <param name="dto">The coffee stamp to pay</param>
    /// <response code="201">Returns information about the paid stamp</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpPost]
    public CoffeeStampPaidDto PayStamp([FromBody] PayCoffeeStampDto dto)
    {
        throw new NotImplementedException();
    }
}
