using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S11Tests
{
    [DataTestMethod]
    [DataRow("2+3", "5")]
    [DataRow("(2+3)*4", "20")]
    [DataRow("2*3+4", "10")]
    [DataRow("2+3*4", "14")]
    [DataRow("(2+3)/4", "1.25")]
    [DataRow("(2+(3*4))/5", "2.8")]
    [DataRow("(2+3)*(4-5)", "-5")]
    [DataRow("3+4*(5-2)^3%5", "11")]
    public void TestEvaluate(string infix, string expected)
    {
        var result = S11.Evaluate(infix);
        Assert.AreEqual(expected, result);
    }
}