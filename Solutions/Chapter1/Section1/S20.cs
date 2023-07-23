namespace Solutions.Chapter1.Section1;

public static class S20
{
    public static double GetLnOfFactorial(int N)
    {
        if (N == 1)
        {
            return Math.Log(1);
        }

        return GetLnOfFactorial(N - 1) + Math.Log(N);
    }
}
