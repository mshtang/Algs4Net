using Solutions.Chapter2.Section2;

namespace SolutionTests.Chapter2.Section2;

[TestClass]
public class S10Tests
{
    [TestMethod]
    public void TestMergeSort()
    {
        var res = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };
        S10<char>.Sort(res);
        var expected = new char[] { 'A', 'E', 'E', 'E', 'E', 'G', 'L', 'M', 'M', 'O', 'P', 'R', 'R', 'S', 'T', 'X' };
        CollectionAssert.AreEqual(expected, res);
    }

    [TestMethod]
    public void TestMergeSortWithInts()
    {
        var res = new int[] { 4, 6, 5, 3, 2 };
        S10<int>.Sort(res);
        var expected = new int[] { 2, 3, 4, 5, 6 };
        CollectionAssert.AreEqual(expected, res);
    }
}