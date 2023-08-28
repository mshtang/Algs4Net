namespace Solutions.Chapter2.Section1;

/// <summary>
/// Insertion Sort with Sentinel
/// </summary>
/// <typeparam name="T"></typeparam>
public static class S24<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        var smallest = arr[0];
        var idx = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(smallest) < 0)
            {
                smallest = arr[i];
                idx = i;
            }
        }
        (arr[0], arr[idx]) = (arr[idx], arr[0]);

        for (var i = 1; i < arr.Length; i++)
        {
            for (var j = i; arr[j].CompareTo(arr[j - 1]) < 0; j--)
            {

                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
            }
        }

    }
}