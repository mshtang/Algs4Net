using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;

[TestClass]
public class S20Tests
{
    [DataTestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 0.693)]
    [DataRow(3, 1.792)]
    [DataRow(4, 3.178)]
    public void TestGetLnFactorial(int input, double expected)
    {
        var res = S20.GetLnOfFactorial(input);
        Assert.AreEqual(expected, res, 1.0e-3);
    }
}
