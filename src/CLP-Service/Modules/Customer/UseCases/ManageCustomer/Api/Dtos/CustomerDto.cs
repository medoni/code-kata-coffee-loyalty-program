using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Customer.UseCases.ManageCustomer.Api.Dtos;

public record CustomerDto(
    string CustomerId,
    string CustomerName
);

public class CustomerDtoExample : IExamplesProvider<CustomerDto>
{
    public CustomerDto GetExamples()
    => new CustomerDto("C1001", "Jane Doe");
}