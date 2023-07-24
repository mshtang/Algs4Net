using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;

[TestClass]
public class S29Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestDataSmallerThan), DynamicDataSourceType.Method)]
    public void TestGetCountOfItemsSmallerThan(int key, int[] arr, int expected)
    {
        var res = S29.GetCountOfItemsSmallerThan(key, arr);
        Assert.AreEqual(expected, res);
    }

    [DataTestMethod]
    [DynamicData(nameof(GetTestDataEqualTo), DynamicDataSourceType.Method)]
    public void TestGetCountOfItemsEqualTo(int key, int[] arr, int expected)
    {
        var res = S29.GetCountOfItemsEqualTo(key, arr);
        Assert.AreEqual(expected, res);
    }

    private static IEnumerable<object[]> GetTestDataSmallerThan()
    {
        var myArray = new[] { 1, 3, 3, 3, 3, 4, 6, 9, 9, 9, 9, 11, 12, 17, 22, 45 };
        yield return new object[] { 1, myArray, 0 };
        yield return new object[] { 3, myArray, 1 };
        yield return new object[] { 9, myArray, 7 };
    }

    private static IEnumerable<object[]> GetTestDataEqualTo()
    {
        var myArray = new[] { 1, 3, 3, 3, 3, 4, 6, 9, 9, 9, 9, 9, 9, 11, 12, 17, 22, 45 };
        yield return new object[] { 1, myArray, 1 };
        yield return new object[] { 3, myArray, 4 };
        yield return new object[] { 9, myArray, 6 };
        yield return new object[] { 46, myArray, 0 };
    }
}
