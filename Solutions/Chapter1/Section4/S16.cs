namespace Solutions.Chapter1.Section4;

public static class S16
{
    public static (double, double) FindClosestPair(double[] nums)
    {
        Array.Sort(nums);
        var smallestDiff = double.MaxValue;
        double item1 = 0;
        double item2 = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            var currDiff = Math.Abs(nums[i] - nums[i - 1]);
            if (currDiff < smallestDiff)
            {
                smallestDiff = currDiff;
                item1 = nums[i - 1];
                item2 = nums[i];
            }
        }
        return (item1, item2);
    }
}