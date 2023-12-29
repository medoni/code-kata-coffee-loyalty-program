using CLPService.Modules.Customer.UseCases.ManageCustomer.Api;

namespace CLPService.UnitTests.Modules.Customer.UseCases.ManageCustomer.Api;

[TestFixture]
[Category(TestCategories.Unit)]
public class CustomerControllerFixture
{
    private CustomerController Sut { get; set; }

    [SetUp]
    public void SetUp()
    {
        Sut = new CustomerController();
    }

    [Test]
    public void GetAsync_Should_Invoke_Correct_Service()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }

    [Test]
    public void GetAllAsync_Should_Invoke_Correct_Service()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }

    [Test]
    public void CreateAsync_Should_Invoke_Correct_Service()
    {
        // arrange

        // act

        // assert
        Assert.Fail();
    }
}
