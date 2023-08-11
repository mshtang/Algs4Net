using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S10Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestBinarySearch(int[] arr, int target, int expected)
    {
        var res = S10.BinarySearch(arr, target);
        Assert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 1, 1, 1, 2, 2 }, 1, 0 };
        yield return new object[] { new int[] { 1, 2, 3, 3, 3, 5 }, 3, 2 };
        yield return new object[] { new int[] { 0, 0, 0, 1, 2, 3, 3, 3, 3 }, 3, 5 };
    }
}