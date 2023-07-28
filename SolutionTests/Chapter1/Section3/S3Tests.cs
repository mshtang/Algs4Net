using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S3Tests
{
    [DataTestMethod]
    [DataRow("[()]{}{[()()]()}", true)]
    [DataRow("[][][]()()(){}", true)]
    [DataRow("(((){{[]}}[[{}]]))", true)]
    [DataRow("((1(){{[11]}}[[{}]]))", true)]
    [DataRow("([)", false)]
    [DataRow("(]{})", false)]
    [DataRow("{}[", false)]
    public void TestAreBracketBalanced(string brackets, bool expected)
    {
        var res = S3.AreBracketsBalanced(brackets);
        Assert.AreEqual(expected, res);
    }
}