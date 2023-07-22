namespace Solutions.Chapter1.Section1;

public static class S19
{
    public static int ComputeFibonacci(int n)
    {
        if (n is 0 or 1)
        {
            return n;
        }

        return ComputeFibonacci(n - 1) + ComputeFibonacci(n - 2);
    }

    public static int ComputeFibonacciImproved(int n)
    {
        if (n is 0 or 1) return n;
        var a = new int[n + 1];
        a[0] = 0;
        a[1] = 1;
        for (var i = 2; i <= n; i++)
        {
            a[i] = a[i - 1] + a[i - 2];
        }
        return a[n];
    }
}
