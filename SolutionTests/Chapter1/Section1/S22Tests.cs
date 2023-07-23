using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;

[TestClass]
public class S22Tests
{
    [ClientTest]
    public static void S22Test()
    {
        var res = S22.Rank(15, new[] { 1, 2, 5, 6, 8, 15, 17, 18, 22, 25 });
        Console.WriteLine($"Found key \"15\" at index {res}");
    }
}
