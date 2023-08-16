using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S16Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestFindClosestPai(double[] nums, (double, double) expected)
    {
        var res = S16.FindClosestPair(nums);
        Assert.AreEqual(expected.Item1, res.Item1, 1e-5);
        Assert.AreEqual(expected.Item2, res.Item2, 1e-5);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new double[] { -5.2, 9.4, 20, -10, 21.1, 40, 50, -20 }, (20.0, 21.1) };
        yield return new object[] { new double[] { -4, -3, 0, 10, 20 }, (-4.0, -3.0) };
        yield return new object[] { new double[] { -10, -3, 0, 2, 4, 20 }, (0.0, 2.0) };
    }
}