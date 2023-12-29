using CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api;

/// <summary>
/// Manages stamps to order coffee
/// </summary>
[Route("api/v1/coffee/stamps")]
[ApiController]
[Consumes("application/json")]
[Produces("application/json")]
[Tags("Stamps")]
public class CoffeeStampController : ControllerBase
{
    /// <summary>
    /// Gets a list of all created stamps by customer id
    /// </summary>
    /// <param name="customerId">Id of the customer</param>
    /// <response code="200">Returns the stamps.</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpGet]
    public Task<List<CoffeeStampDto>> GetByCustomerAsync(string customerId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a stamp by stamp id
    /// </summary>
    /// <param name="stampId">The id of the stamp</param>
    /// <response code="200">Returns the stamp.</response>
    /// <response code="404">Stamp was not found</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpGet("{stampId}")]
    public Task<CoffeeStampDto> GetAsync(string stampId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Creates a new stamp
    /// </summary>
    /// <param name="createDto">Dto to create a new stamp</param>
    /// <response code="201">Returns the created stamp.</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpPost]
    public Task<CoffeeStampCreatedDto> CreateAsync([FromBody] CreateCoffeeStampDto createDto)
    {
        throw new NotImplementedException();
    }
}
