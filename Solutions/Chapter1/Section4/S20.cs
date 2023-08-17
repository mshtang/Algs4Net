namespace Solutions.Chapter1.Section4;

public static class S20
{
    public static int BitonicSearch(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
            return -1;

        var tippingPoint = FindTippingPoint(nums, 0, nums.Length - 1);

        var low = 0;
        var high = tippingPoint;
        var idx = AscendingBinarySearch(nums, target, low, high);
        if (idx != -1) return idx;

        low = tippingPoint + 1;
        high = nums.Length - 1;
        idx = DescendingBinarySearch(nums, target, low, high);
        return idx;
    }

    private static int AscendingBinarySearch(int[] nums, int target, int low, int high)
    {
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (nums[mid] < target)
            {
                low = mid + 1;
            }
            else if (nums[mid] > target)
            {
                high = mid - 1;
            }
            else return mid;
        }
        return -1;

    }

    private static int DescendingBinarySearch(int[] nums, int target, int low, int high)
    {
        while (low <= high)
        {
            var mid = low + (high - low) / 2;
            if (nums[mid] > target)
            {
                low = mid + 1;
            }
            else if (nums[mid] < target)
            {
                high = mid - 1;
            }
            else return mid;
        }
        return -1;
    }

    private static int FindTippingPoint(int[] nums, int low, int high)
    {
        if (low > high) return nums.Length - 1;
        if (low == high) return high;
        var mid = low + (high - low) / 2;
        if (mid == 0)
        {
            if (nums[mid] < nums[mid + 1]) return FindTippingPoint(nums, mid + 1, high);
            else return 0;
        }
        else if (mid == nums.Length - 1) return nums.Length - 1;

        if (nums[mid - 1] > nums[mid] && nums[mid + 1] < nums[mid])
        {
            high = mid - 1;
            return FindTippingPoint(nums, low, high);
        }
        else if (nums[mid - 1] < nums[mid] && nums[mid + 1] > nums[mid])
        {
            low = mid + 1;
            return FindTippingPoint(nums, low, high);
        }
        else return mid;
    }
}