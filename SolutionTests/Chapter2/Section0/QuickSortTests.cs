using Solutions.Chapter2.Section0;

namespace SolutionTests.Chapter2.Section2;

[TestClass]
public class QuickSortTests
{
    [TestMethod]
    public void TestQuickSort()
    {
        var res = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        QuickSort<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'E', 'G', 'L', 'M', 'M', 'O', 'P', 'R', 'R', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }
}