namespace Solutions.Chapter1.Section1;
public static class S14
{
    public static int GetLn(int num)
    {
        var res = 0;
        while (num > 0)
        {
            res++;
            num /= 2;
        }
        return res - 1;
    }
}

