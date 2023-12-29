using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api.Dtos;

public record CoffeeStampCreatedDto(
    string CustomerId,
    string CustomerName,
    string StampId,
    DateTimeOffset StampCreatedAt,
    StampType Type,
    CoffeeVariantDto CoffeeVariant,
    string Message
)
{
    public CoffeeStampCreatedDto(
        string customerId,
        string customerName,
        string stampId,
        DateTimeOffset stampCreatedAt,
        StampType type,
        CoffeeVariantDto coffeeVariant
    )
    : this(
        customerId,
        customerName,
        stampId,
        stampCreatedAt,
        type,
        coffeeVariant,
        $"Coffee stamp created with id '{stampId}'."
    )
    { }
}

public class CoffeeStampCreatedDtoExample : IExamplesProvider<CoffeeStampCreatedDto>
{
    public CoffeeStampCreatedDto GetExamples()
    => new CoffeeStampCreatedDto(
        "C1001",
        "Jane Doe",
        "S1001",
        new DateTimeOffset(2023, 12, 29, 07, 11, 00, TimeSpan.FromHours(1)),
        StampType.Charged,
        new CoffeeVariantDtoExample().GetExamples()
    );
}