namespace Solutions.Chapter1.Section4;

public static class S18
{
    public static int? FindLocalMinimum(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];

        if (nums.Length == 2)
        {
            var res = nums[0] > nums[1] ? nums[1] : nums[0];
            return res;
        }

        return FindLocalMinimum(nums, 0, nums.Length - 1);

    }

    private static int? FindLocalMinimum(int[] nums, int low, int high)
    {
        if (low == high)
            return nums[low];

        var mid = low + (high - low) / 2;
        if (mid > 0 && nums[mid - 1] < nums[mid])
        {
            return FindLocalMinimum(nums, low, mid - 1);
        }
        else if (mid < nums.Length - 1 && nums[mid + 1] < nums[mid])
        {
            return FindLocalMinimum(nums, mid + 1, high);
        }
        else
        {
            return nums[mid];
        }
    }
}