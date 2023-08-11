using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S8Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestFindNumberOfEqualPairs(int[] numbers, int expected)
    {
        var res = S8.FindNumberOfEqualPairs(numbers);
        Assert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 1, 3, 5, 0, 4, 2, 6 }, 0 };
        yield return new object[] { new int[] { 1, 3, 1, 3, 2 }, 2 };
        yield return new object[] { new int[] { 2, 1, 3, 0, 0 }, 1 };
        yield return new object[] { new int[] { 2, 1, 3, 3, 1, 2, 2 }, 5 };
    }
}