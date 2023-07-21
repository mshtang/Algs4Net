namespace SolutionTests.Chapter1.Section1;

using Solutions.Chapter1.Section1;

[TestClass]
public class S14Tests
{
    [DataTestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 1)]
    [DataRow(3, 1)]
    [DataRow(4, 2)]
    [DataRow(5, 2)]
    [DataRow(6, 2)]
    [DataRow(7, 2)]
    [DataRow(8, 3)]
    [DataRow(9, 3)]
    public void S14Test(int input, int expected)
    {
        var res = S14.GetLn(input);
        Assert.AreEqual(expected, res);
    }
}
