namespace Solutions.Chapter1.Section1;

public static class S24
{
    public static int GetGmd(int p, int q)
    {
        if (q == 0) return p;
        var r = p % q;
        return GetGmd(q, r);
    }

    private static int s_step = 0;
    public static int GetEuclid(int p, int q)
    {
        Console.WriteLine($"Step {s_step++}:\t\tp={p}\t\tq={q}");
        if (q == 0) return p;
        var r = p % q;
        return GetEuclid(q, r);
    }
}
