using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Coffee.UseCases.CoffeeOrdering.Api.Dtos;

public record OrderCoffeeDto(
    string CoffeeStampId
);

public class OrderCoffeeDtoExample : IExamplesProvider<OrderCoffeeDto>
{
    public OrderCoffeeDto GetExamples()
    => new OrderCoffeeDto(
        "S1001"
    );
}