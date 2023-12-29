using CLPService.Modules.Stamps.UseCases.CreateCoffeeStamps.Api;

namespace CLPService.UnitTests.Modules.Stamps.UseCases.CreateCoffeeStamps.Api;

[TestFixture]
[Category(TestCategories.Unit)]
public class CoffeeStampControllerFixture
{
    private CoffeeStampController Sut { get; set; }

    [SetUp]
    public void SetUp()
    {
        Sut = new CoffeeStampController();
    }

    [Test]
    public void GetByCustomerAsync_Should_Invoke_Correct_Services()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }

    [Test]
    public void GetAsync_Should_Invoke_Correct_Services()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }

    [Test]
    public void CreateAsync_Should_Invoke_Correct_Services()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }
}
