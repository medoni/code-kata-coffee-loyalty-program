using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api.Dtos;

public record CoffeeStampDto(
    string CustomerId,
    string CustomerName,
    string StampId,
    DateTimeOffset StampCreatedAt,
    StampType Type,
    CoffeeVariantDto CoffeeVariant
);

public enum StampType
{
    Charged,
    Free
}

public class CoffeeStampDtoExample : IExamplesProvider<CoffeeStampDto>
{
    public CoffeeStampDto GetExamples()
    => new CoffeeStampDto(
        "C1001",
        "Jane Doe",
        "S1001",
        new DateTimeOffset(2023, 12, 29, 07, 11, 00, TimeSpan.FromHours(1)),
        StampType.Charged,
        new CoffeeVariantDtoExample().GetExamples()
    );
}