namespace Solutions.Chapter1.Section4;

public static class S14
{
    public static int FourSum(int[] nums)
    {
        var twoSumPairs = new SortedDictionary<int, List<(int, int)>>();

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (!twoSumPairs.TryAdd(nums[i] + nums[j], new List<(int, int)> { (i, j) }))
                {
                    twoSumPairs[nums[i] + nums[j]].Add((i, j));
                }
            }
        }

        var res = new Dictionary<List<int>, int>(new ListEqualityComparer());
        foreach (var key in twoSumPairs.Keys)
        {
            if (twoSumPairs.TryGetValue(-key, out List<(int, int)>? result))
            {
                var tmp = FindUniqueIndexPairs(twoSumPairs[key], result);
                foreach (var uniqueIndices in tmp)
                {
                    res[uniqueIndices] = 1;
                }
            }
        }

        foreach (var item in res)
        {
            Console.WriteLine(PrintList(item.Key));
        }

        return res.Count;
    }

    private static string PrintList(List<int> items)
    {
        var res = "[";
        foreach (var item in items)
        {
            res += item.ToString() + ", ";
        }
        return res.Trim() + "]";
    }

    private static List<List<int>> FindUniqueIndexPairs(List<(int, int)> listA, List<(int, int)> listB)
    {
        var res = new List<List<int>>();
        foreach (var pairA in listA)
        {
            foreach (var pairB in listB)
            {
                if (
                    pairB.Item1 == pairA.Item1 ||
                    pairB.Item1 == pairA.Item2 ||
                    pairB.Item2 == pairA.Item1 ||
                    pairB.Item2 == pairA.Item2)
                {
                    continue;
                }
                var tmp = new List<int> { pairA.Item1, pairA.Item2, pairB.Item1, pairB.Item2 };
                tmp.Sort();
                res.Add(tmp);
            }
        }
        return res;
    }
}

class ListEqualityComparer : IEqualityComparer<List<int>>
{
    public bool Equals(List<int>? x, List<int>? y)
    {
        if (x == null && y == null)
            return true;
        if (x == null || y == null)
            return false;
        if (x.Count != y.Count)
            return false;

        for (var i = 0; i < x.Count; i++)
        {
            if (x[i] != y[i])
                return false;
        }

        return true;
    }

    public int GetHashCode(List<int> obj)
    {
        var hash = 17;
        foreach (var num in obj)
        {
            hash = hash * 31 + num.GetHashCode();
        }
        return hash;
    }
}
