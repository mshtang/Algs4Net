using System.Runtime.CompilerServices;
using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S12Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestFindCommon(int[] arr1, int[] arr2, int[] expected)
    {
        var res = S12.FindCommon(arr1, arr2);
        CollectionAssert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new[] { new int[] { 1, 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 } };
        yield return new[] { new int[] { 0, 1, 2, 2, 5, 6, 6, 8, 25, 25 }, new int[] { -2, 0, 1, 2, 2, 2, 3, 4, 5, 10, 20, 25, 25 }, new int[] { 0, 1, 2, 5, 25 } };
    }
}