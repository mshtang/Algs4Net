namespace Solutions.Chapter1.Section4;

public static class S15
{
    public static int TwoSumFaster(int[] nums)
    {
        Array.Sort(nums);

        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
                dict[num] = dict[num] + 1;
        }

        var count = 0;
        foreach (var num in nums)
        {
            if (dict.ContainsKey(-num))
            {
                count += dict[-num];

                if (num == 0)
                    count--;
            }
        }

        return count / 2;
    }

    public static int ThreeSumFaster(int[] nums)
    {
        Array.Sort(nums);
        var count = 0;
        // consider 0s
        var numOfZeros = 0;
        foreach (var num in nums)
        {
            if (num == 0) numOfZeros++;
        }
        count = (numOfZeros - 2) * (numOfZeros - 1) * numOfZeros / 6;

        var start = 0;
        var end = nums.Length - 1;
        if ((nums[start] > 0 && nums[end] > 0) || (nums[start] < 0 && nums[end] < 0)) return 0;

        for (var i = 0; i < nums.Length; i++)
        {
            start = i + 1;
            end = nums.Length - 1;
            while (start < end)
            {
                if (nums[i] + nums[start] + nums[end] > 0) end--;
                else if (nums[i] + nums[start] + nums[end] < 0) start++;
                else
                {
                    if (nums[start] == 0 && nums[end] == 0)
                    {
                        start++;
                        end--;
                        continue;
                    }
                    int equalElements;
                    if (nums[start] == nums[end])
                    {
                        equalElements = end - start + 1;
                        count += equalElements * (equalElements - 1) / 2;
                        break;
                    }

                    var startElement = nums[start];
                    var equalElements1 = 1;

                    while (start + 1 < end && nums[start + 1] == startElement)
                    {
                        equalElements1++;
                        start++;
                    }

                    var endElement = nums[end];
                    var equalElements2 = 1;

                    while (end - 1 > start && nums[end - 1] == endElement)
                    {
                        equalElements2++;
                        end--;
                    }

                    count += equalElements1 * equalElements2;
                    start++;
                    end--;
                }
            }
        }
        return count;
    }
}