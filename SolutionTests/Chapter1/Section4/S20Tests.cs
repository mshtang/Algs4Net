using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S20Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestBitonicSearch(int[] nums, int target, int expected)
    {
        var result = S20.BitonicSearch(nums, target);
        Assert.AreEqual(expected, result);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 1, 2, 3, 4, -1, -2, -3 }, -1, 4 };
        yield return new object[] { new int[] { 1, 5, 4, 3, 2, 0 }, 5, 1 };
        yield return new object[] { new int[] { 2, 4, 8, 16, 32, 1 }, 2, 0 };
        yield return new object[] { new int[] { 2, 4, 8, 16, 32 }, 99, -1 };
        yield return new object[] { new int[] { 2, 1 }, 1, 1 };
        yield return new object[] { new int[] { 9 }, 9, 0 };
    }
}