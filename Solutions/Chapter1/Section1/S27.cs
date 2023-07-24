namespace Solutions.Chapter1.Section1;

public static class S27
{
    private static int s_count;
    public static double ComputeBinomial(int n, int k, double p)
    {
        Console.WriteLine($"Call no.: {s_count++}");
        if (n == 0 || k < 0) return 1.0;
        return (1.0 - p) * ComputeBinomial(n - 1, k, p) + p * ComputeBinomial(n - 1, k - 1, p);
    }

    public static double ComputeBinomialImproved(int n, int k, double p)
    {
        var arr = new double[n + 1, k + 1];
        for (var i = 0; i <= n; i++)
        {
            for (var j = 0; j <= k; j++)
            {
                arr[i, j] = -1.0;
            }
        }
        return ComputeBinomialImprovedImpl(arr, n, k, p);
    }

    private static double ComputeBinomialImprovedImpl(double[,] arr, int n, int k, double p)
    {
        if (n == 0 && k == 0) return 1.0;
        if (n < 0 || k < 0) return 0.0;

        if (arr[n, k] < 0)
        {
            arr[n, k] = (1 - p) * ComputeBinomialImprovedImpl(arr, n - 1, k, p) + p * ComputeBinomialImprovedImpl(arr, n - 1, k - 1, p);
        }

        return arr[n, k];
    }
}
