using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace Shared.ArchUnitTesting.UnitTests.Rules;

[TestFixture]
[Category(TestCategories.Unit)]
public class HaveUnitTestRuleExtensionMethodsFixture
{
    private Architecture Architecture { get; set; }

    [SetUp]
    public void SetUp()
    {
        Architecture = new ArchLoader().LoadAssemblies(
            typeof(HaveUnitTestRuleExtensionMethodsFixture).Assembly
        ).Build();
    }

    [Test]
    public void HaveUnitTest_Should_Check_For_Correct_Services()
    {
        // arrange
        var testClasses = Classes()
            .That()
            .AreNestedIn(typeof(HaveUnitTestRuleExtensionMethodsFixture));

        var fixtureClasses = Classes()
            .That()
            .HaveNameEndingWith("Fixture");

        var publicMethods = MethodMembers()
            .That()
            .ArePublic().And()
            .AreDeclaredIn(testClasses).And()
            .AreNotDeclaredIn(fixtureClasses).And()
            .AreNoConstructors()
            .As("Public methods");

        // act
        var result = publicMethods
            .Should()
            .HaveUnitTest(testClasses)
            .Evaluate(Architecture);

        // assert
        Assert.That(
            result.Select(x => (((dynamic)x.EvaluatedObject).Name, x.Passed)),
            Is.EquivalentTo(new[]
            {
                ("PublicServiceMethodWithTest()", true),
                ("PublicServiceMethodWithoutTest()", false)
            })
        );
    }

    public class ServiceClassWithUnitTests
    {
        public void PublicServiceMethodWithTest() { }
        public void PublicServiceMethodWithoutTest() { }
        private void PrivateServiceMethod() { }
    }

    public class ServiceClassWithUnitTestsFixture
    {
        public void PublicServiceMethodWithTest_Should() { }
    }
}
