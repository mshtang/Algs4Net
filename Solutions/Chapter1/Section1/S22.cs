namespace Solutions.Chapter1.Section1;

public static class S22
{
    private static int s_depth = 0;
    public static int Rank(int key, int[] a)
    {
        return Rank(key, a, 0, a.Length - 1);
    }

    private static int Rank(int key, int[] a, int lo, int hi)
    {
        s_depth++;
        PrintDepth(s_depth, lo, hi);
        if (lo > hi) return -1;
        var mid = lo + (hi - lo) / 2;
        if (key < a[mid]) return Rank(key, a, lo, mid - 1);
        else if (key > a[mid]) return Rank(key, a, mid + 1, hi);
        else return mid;
    }

    private static void PrintDepth(int depth, int lo, int hi)
    {
        var indention = "";
        for (var i = 0; i < depth; i++)
        {
            indention += "*";
        }
        Console.WriteLine(indention + $" ({lo}, {hi})");
    }
}
