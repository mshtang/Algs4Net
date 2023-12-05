namespace Solutions.Chapter2.Section5;

public static class S3
{
    public static List<T> DeDuplicate<T>(List<T> items)
    {
        var itemsSet = new HashSet<T>(items);
        var itemsList = itemsSet.ToList();
        itemsList.Sort();
        return itemsList;
    }
}