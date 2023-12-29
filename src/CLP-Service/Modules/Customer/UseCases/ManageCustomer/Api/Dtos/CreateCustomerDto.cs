using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Customer.UseCases.ManageCustomer.Api.Dtos;

public record CreateCustomerDto(
    string CustomerName
);

public class CreateCustomerDtoExample : IExamplesProvider<CreateCustomerDto>
{
    public CreateCustomerDto GetExamples()
    => new CreateCustomerDto("Jane Doe");
}
