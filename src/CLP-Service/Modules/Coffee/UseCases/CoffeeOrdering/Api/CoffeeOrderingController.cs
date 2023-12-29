using CLPService.Modules.Coffee.UseCases.CoffeeOrdering.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CLPService.Modules.Coffee.UseCases.CoffeeOrdering.Api;

/// <summary>
/// Responsible for ordering coffee
/// </summary>
[Route("api/v1/coffee/ordering/")]
[ApiController]
[Consumes("application/json")]
[Produces("application/json")]
[Tags("Ordering")]
public class CoffeeOrderingController
{
    /// <summary>
    /// Orders a coffee
    /// </summary>
    /// <param name="createDto">The order for the coffee</param>
    /// <response code="200">Returns the information about the ordered coffee.</response>
    /// <response code="400">
    ///     Something happened with your order. This can occur when:
    ///     <ul>
    ///         <li>Stamp not paid</li>
    ///         <li>Coffee variant not order able</li>
    ///     </ul>
    /// </response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpPost("order")]
    public Task<BrewedCoffeeDto> OrderAsync([FromBody] OrderCoffeeDto createDto)
    {
        throw new NotImplementedException();
    }
}
