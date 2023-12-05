namespace Solutions.Chapter2.Section5;

public static class S2
{
    public static List<string> FindCompoundWords(List<string> candidates)
    {
        var words = new HashSet<string>(candidates);
        var res = new List<string>();

        for (var i = 0; i < candidates.Count - 1; i++)
        {
            for (var j = i + 1; j < candidates.Count; j++)
            {
                var compound1 = candidates[i] + candidates[j];
                if (words.Contains(compound1))
                {
                    res.Add(compound1);
                }

                var compound2 = candidates[j] + candidates[i];
                if (words.Contains(compound2))
                {
                    res.Add(compound2);
                }
            }
        }

        return res.ToList();
    }
}