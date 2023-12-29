using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api.Dtos;

public record CreateCoffeeStampDto(
    CoffeeVariantDto CoffeeVariant
);

public class CreateCoffeeStampDtoExample : IExamplesProvider<CreateCoffeeStampDto>
{
    public CreateCoffeeStampDto GetExamples()
    => new CreateCoffeeStampDto(
        new CoffeeVariantDtoExample().GetExamples()
    );
}