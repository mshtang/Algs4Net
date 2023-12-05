namespace Solutions.Chapter2.Section0;

public static class QuickSort<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        var random = new Random();
        Shuffle(arr, random);
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Shuffle(T[] arr, Random random)
    {
        var n = arr.Length;
        for (var i = n - 1; i > 0; i--)
        {
            var j = random.Next(0, i + 1);
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }

    private static void Sort(T[] arr, int low, int high)
    {
        if (high <= low) return;
        var j = Partition(arr, low, high);
        Sort(arr, low, j - 1);
        Sort(arr, j + 1, high);
    }

    private static int Partition(T[] arr, int low, int high)
    {
        var i = low;
        var j = high + 1;
        var pivot = arr[low];

        while (true)
        {
            while (arr[++i].CompareTo(pivot) < 0)
            {
                if (i == high) break;
            }

            while (arr[--j].CompareTo(pivot) > 0)
            {
                if (j == low) break;
            }

            if (i >= j) break;
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        (arr[low], arr[j]) = (arr[j], arr[low]);
        return j;
    }
}