namespace Solutions.Chapter2.Section2;

public static class S10<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        var aux = new T[arr.Length];
        Sort(arr, 0, arr.Length - 1, aux);
    }

    private static void Sort(T[] arr, int low, int high, T[] aux)
    {
        if (low >= high) return;
        var mid = low + (high - low) / 2;
        Sort(arr, low, mid, aux);
        Sort(arr, mid + 1, high, aux);
        Merge(arr, low, mid, high, aux);
    }

    private static void Merge(T[] arr, int low, int mid, int high, T[] aux)
    {
        var idx = low;
        for (var k = low; k <= mid; k++)
        {
            aux[idx++] = arr[k];
        }
        for (var k = high; k > mid; k--)
        {
            aux[idx++] = arr[k];
        }

        var i = low;
        var j = high;
        for (var k = low; k <= high; k++)
        {
            if (aux[i].CompareTo(aux[j]) < 0) arr[k] = aux[i++];
            else arr[k] = aux[j--];
        }
    }
}