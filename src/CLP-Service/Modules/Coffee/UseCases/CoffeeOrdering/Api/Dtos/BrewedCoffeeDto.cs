using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Coffee.UseCases.CoffeeOrdering.Api.Dtos;

public record BrewedCoffeeDto(
    string CoffeeId,
    string UsedStampId,
    string CoffeeVariant
);

public class BrewedCoffeeDtoExample : IExamplesProvider<BrewedCoffeeDto>
{
    public BrewedCoffeeDto GetExamples()
    => new BrewedCoffeeDto(
        "F1001",
        "S1001",
        "Americano with milk"
    );
}