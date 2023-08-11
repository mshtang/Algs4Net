using System.Runtime;

namespace Solutions.Chapter1.Section4;

public static class S10
{
    /// <summary>
    /// Binary search returns the smallest index in the array of the searching target
    /// </summary>
    /// <param name="arr">the searching array</param>
    /// <param name="target">target to search</param>
    /// <returns>the smallest index in the array of the searching target</returns>
    public static int BinarySearch(int[] arr, int target)
    {
        return BinarySearch(arr, target, 0, arr.Length);
    }

    private static int BinarySearch(int[] arr, int target, int low, int high)
    {
        if (low > high) return -1;
        var mid = low + (high - low) / 2;
        if (target < arr[mid]) return BinarySearch(arr, target, low, mid - 1);
        else if (target > arr[mid]) return BinarySearch(arr, target, mid + 1, high);
        else
        {
            var possibleIdx = BinarySearch(arr, target, low, mid - 1);
            if (possibleIdx == -1) return mid;
            else return possibleIdx;
        }
    }
}