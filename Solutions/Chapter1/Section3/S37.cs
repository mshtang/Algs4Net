namespace Solutions.Chapter1.Section3;

public static class S37
{
    public static List<int> Josephus(int n, int m)
    {
        var orig = new Queue<int>();
        var p = 0;
        var res = new List<int>();
        while (p < n)
        {
            orig.Enqueue(p);
            p++;
        }
        while (orig.Count > 0)
        {
            var k = 0;
            while (k < m - 1)
            {
                var tmp = orig.Dequeue();
                orig.Enqueue(tmp);
                k++;
            }
            res.Add(orig.Dequeue());
        }
        return res;
    }
}