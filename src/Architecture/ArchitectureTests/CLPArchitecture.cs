using ArchUnitNET.Domain;
using ArchUnitNET.Loader;
using CLPService;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

namespace ArchitectureTests;

internal static class CLPArchitecture
{
    public static Architecture Architecture { get; }
    public static IObjectProvider<Class> PublicClasses { get; }
    public static IObjectProvider<Class> PublicDtos { get; }
    public static IObjectProvider<Class> ClassesThatShouldBeTested { get; }

    public static IObjectProvider<Class> UnitTestClasses { get; }
    public static IObjectProvider<Class> IntegrationTestClasses { get; }
    public static IObjectProvider<Class> TestClasses { get; }

    static CLPArchitecture()
    {
        Architecture =
            new ArchLoader().LoadAssemblies(
                typeof(Program).Assembly,
                typeof(CLPService.IntegrationTests.Tests).Assembly,
                typeof(CLPService.UnitTests.Tests).Assembly
            ).Build();

        UnitTestClasses =
           Classes()
           .That()
           .ResideInAssembly(@"\.unittests\W", true)
           .As("Unit Test classes");

        IntegrationTestClasses =
            Classes()
            .That()
            .ResideInAssembly(@"\.integrationtests\W", true)
            .As("Integration Test classes");

        TestClasses =
            Classes()
            .That()
            .Are(UnitTestClasses).Or()
            .Are(IntegrationTestClasses)
            .As("Test classes");

        PublicDtos =
            Classes()
            .That()
            .AreNot(TestClasses).And()
            .HaveNameEndingWith("Dto")
            .And()
            .ArePublic()
            .As("Public Dtos");

        PublicClasses =
            Classes()
            .That()
            .AreNot(TestClasses).And()
            .ArePublic().And()
            .AreNot(PublicDtos).And()
            .AreNot(TestClasses)
            .As("Public Classes");

        ClassesThatShouldBeTested =
            Classes()
            .That()
            .Are(PublicClasses).And()
            .DoNotHaveName("Program").And()
            .DoNotImplementInterface(@"Swashbuckle\.AspNetCore\.Filters\.IExamplesProvider\W", true)
            .As("Public classes that should be tested");
    }
}
