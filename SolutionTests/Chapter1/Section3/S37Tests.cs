using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S37Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestJosephus(int n, int m, List<int> expected)
    {
        List<int> res = S37.Josephus(n, m);
        CollectionAssert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { 7, 2, new List<int> { 1, 3, 5, 0, 4, 2, 6 } };
        yield return new object[] { 5, 2, new List<int> { 1, 3, 0, 4, 2 } };
        yield return new object[] { 4, 3, new List<int> { 2, 1, 3, 0 } };

    }
}