namespace SolutionTests.Chapter1.Section1;
using Solutions.Chapter1.Section1;

[TestClass]
public class S9Tests
{
    [DataTestMethod]
    [DataRow(0, "0")]
    [DataRow(1, "1")]
    [DataRow(2, "10")]
    [DataRow(3, "11")]
    [DataRow(4, "100")]
    [DataRow(5, "101")]
    public void Test(int before, string expected)
    {
        var res = S9.ConvertToBinString(before);
        Assert.AreEqual(expected, res);
    }
}
