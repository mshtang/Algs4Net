namespace Solutions.Chapter1.Section5;

public class S12
{
    private readonly int[] _parent;
    public int Count { get; set; }

    public S12(int capacity)
    {
        _parent = new int[capacity];
        Count = capacity;
        for (var i = 0; i < capacity; i++)
        {
            _parent[i] = i;
        }
    }

    public void Union(int p, int q)
    {
        var rootP = Find(p);
        var rootQ = Find(q);
        if (rootP == rootQ) return;
        _parent[rootP] = rootQ;
        Count--;
    }

    public int Find(int p)
    {
        Validate(p);
        var root = p;
        while (root != _parent[root])
            root = _parent[root];

        while (p != _parent[p])
        {
            var nextParent = _parent[p];
            _parent[p] = root;
            p = nextParent;
        }

        return p;
    }

    public bool Connected(int p, int q) => Find(p) == Find(q);

    private void Validate(int p)
    {
        if (p < 0 || p >= _parent.Length)
            throw new ArgumentOutOfRangeException($"Index {p} is out of range from 0 to {_parent.Length}");
    }
}