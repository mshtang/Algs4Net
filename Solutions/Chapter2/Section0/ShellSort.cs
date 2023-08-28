namespace Solutions.Chapter2.Section0;

public static class ShellSort<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        var h = 1;
        while (h < arr.Length / 3) h = 3 * h + 1;
        while (h >= 1)
        {
            for (var i = h; i < arr.Length; i++)
            {
                for (var j = i; j >= h; j -= h)
                {
                    if (arr[j].CompareTo(arr[j - h]) < 0)
                    {
                        (arr[j - h], arr[j]) = (arr[j], arr[j - h]);
                    }
                }
            }
            h /= 3;
        }
    }
}