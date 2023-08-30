using Solutions.Chapter2.Section2;

namespace SolutionTests.Chapter2.Section2;

[TestClass]
public class S9Tests
{
    [TestMethod]
    public void TestMergeSort()
    {
        var res = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        S9<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'E', 'G', 'L', 'M', 'M', 'O', 'P', 'R', 'R', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }
}