namespace Solutions.Chapter2.Section0;

public static class MergeSort<T> where T : IComparable<T>
{
    private static T[] s_aux = Array.Empty<T>();

    public static void Sort(T[] arr)
    {
        s_aux = new T[arr.Length];
        Sort(arr, 0, arr.Length - 1);
    }

    public static void SortBU(T[] arr)
    {
        s_aux = new T[arr.Length];
        for (var sz = 1; sz < arr.Length; sz += sz)
        {
            for (var low = 0; low < arr.Length - sz; low += sz + sz)
            {
                Merge(arr, low, low + sz - 1, Math.Min(low + sz + sz - 1, arr.Length - 1));
            }
        }
    }

    private static void Sort(T[] arr, int low, int high)
    {
        if (low >= high) return;
        var mid = low + (high - low) / 2;
        Sort(arr, low, mid);
        Sort(arr, mid + 1, high);
        Merge(arr, low, mid, high);
    }

    private static void Merge(T[] arr, int low, int mid, int high)
    {
        for (var k = low; k <= high; k++)
        {
            s_aux[k] = arr[k];
        }

        var i = low;
        var j = mid + 1;
        for (var k = low; k <= high; k++)
        {
            if (i > mid) arr[k] = s_aux[j++];
            else if (j > high) arr[k] = s_aux[i++];
            else if (s_aux[i].CompareTo(s_aux[j]) < 0) arr[k] = s_aux[i++];
            else arr[k] = s_aux[j++];
        }
    }
}