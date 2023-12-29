using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Payment.UseCases.StampPayment.Api.Dtos;

public record CoffeeStampPaidDto(
    string CoffeeStampId,
    decimal PaidPrice
);

public class CoffeeStampPaidDtoExample : IExamplesProvider<CoffeeStampPaidDto>
{
    public CoffeeStampPaidDto GetExamples()
    => new CoffeeStampPaidDto(
        "S1001",
        3.42m
    );
}