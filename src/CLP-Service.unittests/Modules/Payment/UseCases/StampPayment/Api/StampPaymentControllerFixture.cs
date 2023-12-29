
using CLPService.Modules.Payment.UseCases.StampPayment.Api;

namespace CLPService.UnitTests.Modules.Payment.UseCases.StampPayment.Api;

[TestFixture]
[Category(TestCategories.Unit)]
public class StampPaymentControllerFixture
{
    private StampPaymentController Sut { get; set; }

    [SetUp]
    public void SetUp()
    {
        Sut = new StampPaymentController();
    }

    [Test]
    public void PayStampAsync_Should_Invoke_Correct_Service()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }
}
