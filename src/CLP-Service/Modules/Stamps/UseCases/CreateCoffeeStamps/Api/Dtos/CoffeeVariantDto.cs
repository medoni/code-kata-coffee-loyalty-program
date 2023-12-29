using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api.Dtos;

// TODO: implement
public record CoffeeVariantDto(
    string type,
    List<string> extras
);

public class CoffeeVariantDtoExample : IExamplesProvider<CoffeeVariantDto>
{
    public CoffeeVariantDto GetExamples()
    => new CoffeeVariantDto("Americano", new() { "milk" });
}