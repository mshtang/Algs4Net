using Solutions.Chapter2.Section0;

namespace SolutionTests.Chapter2.Section0;

[TestClass]
public class MergeSortTests
{
    [TestMethod]
    public void TestMergeSort()
    {
        var res = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        MergeSort<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'E', 'G', 'L', 'M', 'M', 'O', 'P', 'R', 'R', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }

    [TestMethod]
    public void TestMergeSortBU()
    {
        var res = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        MergeSort<char>.SortBU(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'E', 'G', 'L', 'M', 'M', 'O', 'P', 'R', 'R', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }
}