using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S18Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestFindLocalMinimum(int[] nums, List<int> expected)
    {
        var res = S18.FindLocalMinimum(nums);
        CollectionAssert.Contains(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 10, -9, 20, 25, 21, 40, 50, -20 }, new List<int> { -9, 20 } };
        yield return new object[] { new int[] { -4, -3, 9, 4, 10, 2, 20 }, new List<int> { -4, 4, 2 } };
        yield return new object[] { new int[] { 5, -3, -5, -6, -7, -8 }, new List<int> { -8 } };
        yield return new object[] { new int[] { 5 }, new List<int> { 5 } };
        yield return new object[] { new int[] { 10, 20 }, new List<int> { 10 } };
        yield return new object[] { new int[] { 7, 20, 30 }, new List<int> { 7 } };
    }
}