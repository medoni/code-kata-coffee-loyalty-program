using CLPService.Modules.Coffee.UseCases.CoffeeOrdering.Api;

namespace CLPService.UnitTests.Modules.Coffee.UseCases.CoffeeOrdering.Api;

[TestFixture]
[Category(TestCategories.Unit)]
public class CoffeeOrderingControllerFixture
{
    private CoffeeOrderingController Sut { get; set; }

    [SetUp]
    public void SetUp()
    {
        Sut = new CoffeeOrderingController();
    }

    [Test]
    public void OrderAsync_Should_Invoke_Correct_Service()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }
}
