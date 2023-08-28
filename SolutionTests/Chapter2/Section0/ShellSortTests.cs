using Solutions.Chapter2.Section0;

namespace SolutionTests.Chapter2.Section0;

[TestClass]
public class ShellSortTests
{
    [TestMethod]
    public void TestShellSort()
    {
        var res = new char[] { 'S', 'H', 'E', 'L', 'L', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        ShellSort<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'H', 'L', 'L', 'L', 'M', 'O', 'P', 'R', 'S', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }
}