using System.Diagnostics;
using Solutions.Chapter1.Section1;

namespace SolutionTests.Chapter1.Section1;
[TestClass]
public class S19Tests
{
    private readonly Stopwatch _stopwatch;

    public S19Tests() => _stopwatch = new Stopwatch();

    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    [DataRow(7, 13)]
    public void TestRecursiveForm(int input, int expected)
    {
        var res = S19.ComputeFibonacci(input);
        Assert.AreEqual(expected, res);
    }

    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(1, 1)]
    [DataRow(2, 1)]
    [DataRow(3, 2)]
    [DataRow(4, 3)]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    [DataRow(7, 13)]
    public void TestMemoizationForm(int input, int expected)
    {
        var res = S19.ComputeFibonacciImproved(input);
        Assert.AreEqual(expected, res);
    }

    [ClientTest(hidden: true)]
    public void TestRecursiveImplementation()
    {
        Console.WriteLine("=================== Running recursive implementation ===================");
        for (var i = 5; i < 50; i++)
        {
            _stopwatch.Start();
            _ = S19.ComputeFibonacci(i);
            _stopwatch.Stop();

            Console.WriteLine($"It took {_stopwatch.Elapsed}s for i={i} to finish.");
        }
        Console.WriteLine("#################### End of testing ####################");
    }

    [ClientTest]
    public void TestMemoizationImplementation(string[] args)
    {
        var count = int.Parse(args[0]);
        Console.WriteLine("=================== Running memoization implementation ===================");
        for (var i = 5; i < count; i++)
        {
            _stopwatch.Start();
            _ = S19.ComputeFibonacciImproved(i);
            _stopwatch.Stop();

            Console.WriteLine($"It took {_stopwatch.Elapsed}s for i={i} to finish.");
        }
        Console.WriteLine("#################### End of testing ####################");
    }
}
