using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S10Tests
{
    [DataTestMethod]
    [DataRow("2+3", "23+")]
    [DataRow("(2+3)*4", "23+4*")]
    [DataRow("2*3+4", "23*4+")]
    [DataRow("2+3*4", "234*+")]
    [DataRow("(2+3)/4", "23+4/")]
    [DataRow("(2+(3*4))/5", "234*+5/")]
    [DataRow("(2+3)*(4-5)", "23+45-*")]
    [DataRow("3+4*(2-1)^2%5", "3421-2^5%*+")]
    public void TestConvertInfixToPostfix(string infix, string expected)
    {
        var res = S10.ConvertInfixToPostfix(infix);
        Assert.AreEqual(expected, res);
    }
}