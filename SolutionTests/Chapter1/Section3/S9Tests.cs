using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S9Tests
{
    [DataTestMethod]
    [DataRow("1+2)*3-4)*5-6)))", "((1+2)*((3-4)*(5-6)))")]
    public void TestConvertToInfix(string expression, string expected)
    {
        var res = S9.ConvertToInfix(expression);
        Assert.AreEqual(expected, res);
    }
}