namespace Solutions.Chapter1.Section4;

public static class S8
{
    public static int FindNumberOfEqualPairs(int[] numbers)
    {
        Array.Sort(numbers);
        var count = 0;
        var repeat = 1;
        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                repeat++;
            }
            else
            {
                if (repeat > 1)
                {
                    count += (repeat - 1) * repeat / 2;
                    repeat = 1;
                }
            }
        }
        if (repeat > 1)
        {
            count += (repeat - 1) * repeat / 2;
        }
        return count;
    }
}