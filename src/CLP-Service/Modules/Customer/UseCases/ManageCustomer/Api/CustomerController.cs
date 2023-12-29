using CLPService.Modules.Customer.UseCases.ManageCustomer.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CLPService.Modules.Customer.UseCases.ManageCustomer.Api;

/// <summary>
/// Responsible for managing customers
/// </summary>
[Route("api/v1/customer")]
[ApiController]
[Consumes("application/json")]
[Produces("application/json")]
[Tags("Customer")]
public class CustomerController : ControllerBase
{
    /// <summary>
    /// Returns a customer by id
    /// </summary>
    /// <param name="customerId">The id of the customer to get.</param>
    /// <response code="200">Returns the found customer.</response>
    /// <response code="404">The customer with given id was not found.</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpGet("{customerId}")]
    [ProducesResponseType<CustomerDto>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public Task<CustomerDto> GetAsync(string customerId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns all customer
    /// </summary>
    /// <response code="200">Returns all customer.</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpGet]
    [ProducesResponseType<CustomerDto[]>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Creates a new customer
    /// </summary>
    /// <response code="201">Returns the created customer.</response>
    /// <response code="500">Internal Server Error occurred.</response>
    [HttpPost]
    [ProducesResponseType<CustomerCreatedDto>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public Task<CustomerCreatedDto> CreateAsync(
        [FromBody] CreateCustomerDto createDto
    )
    {
        throw new NotImplementedException();
    }
}
