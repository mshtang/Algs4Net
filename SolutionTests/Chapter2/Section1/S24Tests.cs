using Solutions.Chapter2.Section1;

namespace SolutionTests.Chapter2.Section1;

[TestClass]
public class S24Tests
{
    [TestMethod]
    public void TestInsertionWithSentinel()
    {
        var res = new char[] { 'S', 'H', 'E', 'L', 'L', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        S24<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'H', 'L', 'L', 'L', 'M', 'O', 'P', 'R', 'S', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }
}