using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;

[TestClass]
public class S27Tests
{
    [ClientTest]
    public static void ShowCallCount(string[] args)
    {
        var n = int.Parse(args[0]);
        var k = int.Parse(args[1]);
        var p = args.Length == 3 ? double.Parse(args[2]) : 0.25;
        _ = S27.ComputeBinomial(n, k, p);
    }

    [DataTestMethod]
    [DataRow(6, 4, 0.3, 0.0595)]
    [DataRow(10, 5, 0.25, 0.0584)]
    [DataRow(100, 50, 0.3, 0.000013026)]
    public void TestComputeBinomialImproved(int n, int k, double p, double expected)
    {
        var s = S27.ComputeBinomialImproved(n, k, p);
        Assert.AreEqual(expected, s, 0.0001);
    }
}
