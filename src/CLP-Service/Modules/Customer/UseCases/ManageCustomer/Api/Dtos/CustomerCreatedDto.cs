using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Customer.UseCases.ManageCustomer.Api.Dtos;

public record CustomerCreatedDto(
    string CustomerId,
    string CustomerName,
    DateTimeOffset CreatedAt,
    string Message
)
{
    public CustomerCreatedDto(
        string customerId,
        string customerName,
        DateTimeOffset createdAt
    )
    : this(
        customerId,
        customerName,
        createdAt,
        $"Customer '{customerName}' successfully created."
    )
    {

    }
}

public class CustomerCreatedDtoExample : IExamplesProvider<CustomerCreatedDto>
{
    public CustomerCreatedDto GetExamples()
    => new CustomerCreatedDto(
        "C1001",
        "Jane Doe",
        new DateTime(2023, 12, 28, 06, 24, 00, DateTimeKind.Utc)
    );
}