using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;

[TestClass]
public class S24Tests
{
    [DataTestMethod]
    [DataRow(1, 1, 1)]
    [DataRow(2, 3, 1)]
    [DataRow(2, 4, 2)]
    [DataRow(2, 5, 1)]
    [DataRow(3, 6, 3)]
    [DataRow(3, 7, 1)]
    [DataRow(3, 8, 1)]
    [DataRow(6, 9, 3)]
    public void GetGmd(int p, int q, int expected)
    {
        var res = S24.GetGmd(p, q);
        Assert.AreEqual(expected, res);
    }

    [ClientTest]
    public static void GetEuclid(string[] args)
    {
        var p = int.Parse(args[0]);
        var q = int.Parse(args[1]);
        var res = S24.GetEuclid(p, q);
        Console.WriteLine($"------------- GCD({p}, {q})={res} -------------");
    }
}
