using Solutions.Utils;

namespace Solutions.Chapter2.Section0;

public static class Multiway
{
    public static string Merge(TextInput[] streams)
    {
        var n = streams.Length;
        PriorityQueue<int, string> pq = new(n);
        for (var i = 0; i < n; i++)
        {
            if (!streams[i].IsEmpty)
            {
                var s = streams[i].ReadString();
                if (!string.IsNullOrEmpty(s)) pq.Enqueue(i, s);
            }
        }

        var res = "";
        while (pq.TryDequeue(out var ii, out var ss))
        {
            res += ss + " ";
            //Console.WriteLine(s + " ");
            if (!streams[ii].IsEmpty)
            {
                var s = streams[ii].ReadString();
                if (!string.IsNullOrEmpty(s)) pq.Enqueue(ii, s);
            }
        }

        return res.TrimEnd();
    }
}