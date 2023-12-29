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

        var publicMethods = MethodMembers()
            .That()
            .ArePublic().And()
            .AreDeclaredIn(testClasses).And()
            .AreNoConstructors()
            .As("Public methods");

        // act
        var result = publicMethods
            .Should()
            .HaveUnitTest(testClasses)
            .Evaluate(Architecture);

        // assert
        Assert.That(
            result.Select(x => (x.EvaluatedObject, x.Passed)),
            Is.EquivalentTo(new[]
            {
                ("System.Void Shared.ArchUnitTesting.UnitTests.Rules.HaveUnitTestRuleExtensionMethodsFixture/ServiceClassWithUnitTests::PublicServiceMethodWithTest()", true)
            })
        );
    }

    public class ServiceClassWithUnitTests
    {
        public void PublicServiceMethodWithTest() { }
        public void PublicSericeMethodWithoutTest() { }
        private void PrivateServiceMethod() { }
    }

    public class ServiceClassWithUnitTestsFixture
    {
        public void PublicServiceMethodWithTest_Should() { }
    }
}
