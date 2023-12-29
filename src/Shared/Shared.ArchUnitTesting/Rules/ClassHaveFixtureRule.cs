using ArchUnitNET.Domain;
using ArchUnitNET.Domain.Extensions;

namespace ArchitectureTests.Rules;
internal static class ClassHaveFixtureRule
{
    public static IType? GetFixtureTypeFromClass(
        Architecture architecture,
        IType type,
        IObjectProvider<Class> unitTestClasses,
        string classFixtureName
    )
    {
        var matchingName = type.Name + classFixtureName;

        return unitTestClasses.GetObjects(architecture)
            .FirstOrDefault(x => x.NameMatches(matchingName));
    }
}
