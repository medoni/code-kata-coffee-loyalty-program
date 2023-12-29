using Swashbuckle.AspNetCore.Filters;

namespace CLPService.Modules.Payment.UseCases.StampPayment.Api.Dtos;

public record PayCoffeeStampDto(
    string CoffeeStampId
);

public class PayCoffeeStampDtoExample : IExamplesProvider<PayCoffeeStampDto>
{
    public PayCoffeeStampDto GetExamples()
    => new PayCoffeeStampDto(
        "S1001"
    );
}