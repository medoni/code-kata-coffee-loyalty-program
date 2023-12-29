using ArchUnitNET.Fluent;
using ArchUnitNET.NUnit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests.UnitTests;

[TestFixture]
[Category(TestCategories.Architecture)]
public class PublicMethodsShouldHaveUnitTestFixture
{

    [Test]
    public void Verify()
    {
        PublicMethodsShouldHaveUnitTestRule.Check(CLPArchitecture.Architecture);
    }

    private static readonly IArchRule PublicMethodsShouldHaveUnitTestRule =
        MethodMembers()
            .That()
            .ArePublic().And()
            .AreDeclaredIn(CLPArchitecture.ClassesThatShouldBeTested).And()
            .AreNoConstructors()
            .As("Public methods")
        .Should()
            .HaveUnitTest(CLPArchitecture.UnitTestClasses);
}
