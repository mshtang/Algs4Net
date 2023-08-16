using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S15Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestTwoSumFaster(int[] nums, int expected)
    {
        var res = S15.TwoSumFaster(nums);
        Assert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { -5, -2, -1, 0, 0, 1, 2, 3 }, 3 };
        yield return new object[] { new int[] { -5, -2, -1, 0, 1, 2, 3 }, 2 };
    }

    [DataTestMethod]
    [DynamicData(nameof(GetTestData2), DynamicDataSourceType.Method)]
    public void TestThreeSumFaster(int[] nums, int expected)
    {
        var res = S15.ThreeSumFaster(nums);
        Assert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData2()
    {
        yield return new object[] { new int[] { -10, -10, -5, 0, 5, 10, 10, 15, 20 }, 8 };
        yield return new object[] { new int[] { -3, -2, 2, 3, 5, 99 }, 1 };
        yield return new object[] { new int[] { -10, -10, -10, 10 }, 0 };
        yield return new object[] { new int[] { 0, 0, 0, 0, 0, 0, 0 }, 35 };
        yield return new object[] { new int[] { -2, -1, 0, 0, 0, 0, 0, 0, 3 }, 21 };
    }
}