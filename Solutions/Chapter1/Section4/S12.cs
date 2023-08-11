namespace Solutions.Chapter1.Section4;

public static class S12
{
    public static int[] FindCommon(int[] arr1, int[] arr2)
    {
        var res = new List<int>();
        for (var i = 0; i < arr2.Length; i++)
        {
            if (arr1.Contains(arr2[i]))
                res.Add(arr2[i]);
        }

        return new HashSet<int>(res).ToArray();
    }
}