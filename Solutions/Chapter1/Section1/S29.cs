namespace Solutions.Chapter1.Section1;

public static class S29
{
    public static int GetCountOfItemsSmallerThan(int key, int[] arr)
    {
        var idx = BinarySearch(key, arr, 0, arr.Length - 1);
        while (idx >= 0 && arr[idx] == key)
        {
            idx--;
        }
        return idx + 1;
    }

    public static int GetCountOfItemsEqualTo(int key, int[] arr)
    {
        var startingIdx = GetCountOfItemsSmallerThan(key, arr);
        var count = 0;
        while (startingIdx < arr.Length - 1 && arr[startingIdx] == key)
        {
            count++;
            startingIdx++;
        }
        return count;
    }

    private static int BinarySearch(int key, int[] arr, int lo, int hi)
    {
        if (lo > hi) return -1;
        var mid = lo + (hi - lo) / 2;
        if (key < arr[mid]) return BinarySearch(key, arr, lo, mid - 1);
        else if (key > arr[mid]) return BinarySearch(key, arr, mid + 1, hi);
        else return mid;
    }
}
