namespace Solutions.Chapter1.Section1;

public static class S9
{
    public static string ConvertToBinString(int n)
    {
        if (n == 0)
        {
            return "0";
        }

        var res = "";
        while (n > 0)
        {
            res = (n % 2).ToString(System.Globalization.CultureInfo.InvariantCulture) + res;
            n /= 2;
        }
        return res;
    }
}
