using Solutions.Chapter1.Section4;

namespace SolutionTests.Chapter1.Section4;

[TestClass]
public class S14Tests
{
    [DataTestMethod]
    [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
    public void TestFourSum(int[] nums, int expected)
    {
        var result = S14.FourSum(nums);
        Assert.AreEqual(expected, result);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 0 };
        yield return new object[] { new int[] { -2, -1, 1, 2, 3 }, 1 };
        yield return new object[] { new int[] { 1, -1, 2, -2, 3, -3, 0 }, 5 };
        yield return new object[] { new int[] { 1, -1, 2, -2, 3, -3, -1, -2, 4, 5, -4, -5 }, 36 };
    }

    [ClientTest]
    public static void ClientTestFourSum(string[] args)
    {
        var n = args.Length;
        var nums = new List<int>();
        var i = 0;
        while (n > 0)
        {
            nums.Add(int.Parse(args[i]));
            i++;
            n--;
        }
        var result = S14.FourSum(nums.ToArray());
        Console.WriteLine($"Count is {result}");
    }
}