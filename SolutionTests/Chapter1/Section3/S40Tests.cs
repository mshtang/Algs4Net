using Solutions.Chapter1.Section3;

namespace SolutionTests.Chapter1.Section3;

[TestClass]
public class S40Tests
{
    [ClientTest]
    public static void TestMoveToFront(string[] args)
    {
        var s40 = new S40();
        var i = 0;
        while (args.Length > i)
        {
            s40.MoveToFront(args[i++]);
        }
        Console.WriteLine($"The final sequence is {string.Join(" ", s40.Sequence)}");
    }

    [ClientTest]
    public static void TestMoveToFrontByLinkedList(string[] args)
    {
        var s40 = new S40();
        var i = 0;
        while (args.Length > i)
        {
            s40.MoveToFrontByLinkedList(args[i++]);
        }
        Console.WriteLine($"The final sequence is {string.Join(" ", s40.SequenceByLinkedList)}");
    }
}