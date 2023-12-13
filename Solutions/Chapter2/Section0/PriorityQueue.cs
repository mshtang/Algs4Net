namespace Solutions.Chapter2.Section0;

public class PriorityQueue<T> where T : IComparable<T>
{
    private T[] _arr;
    private int _N = 0;

    public PriorityQueue() : this(1)
    { }

    public PriorityQueue(int initCapacity)
    {
        _arr = new T[initCapacity + 1];
        _N = 0;
    }

    public PriorityQueue(T[] a)
    {
        _N = a.Length;
        _arr = new T[a.Length + 1];
        for (var i = 0; i < _N; i++)
        {
            _arr[i + 1] = a[i];
        }
        for (var k = _N / 2; k > 0; k--)
        {
            Sink(k);
        }
    }

    public void Insert(T v)
    {
        if (_N == _arr.Length - 1) Resize(2 * _arr.Length);
        _arr[++_N] = v;
        Swim(_N);
    }

    public T DelMax()
    {
        var maxItem = _arr[1];
        var lastIndex = _N--;
        (_arr[1], _arr[lastIndex]) = (_arr[lastIndex], _arr[1]);
        _arr[lastIndex++] = default;
        Sink(1);
        if (_N > 0 && (_N == (_arr.Length - 1) / 4)) Resize(_arr.Length / 2);
        return maxItem;
    }

    public T Max => _arr[1];

    public bool IsEmpty => _N == 0;

    public int Length => _N;

    public void Resize(int capacity)
    {
        T[] tmp = new T[capacity];
        for (var i = 1; i <= _N; i++)
        {
            tmp[i] = _arr[i];
        }
        _arr = tmp;
    }

    private void Swim(int k)
    {
        while (k > 1 && Less(k / 2, k))
        {
            (_arr[k], _arr[k / 2]) = (_arr[k / 2], _arr[k]);
            k /= 2;
        }
    }

    private bool Less(int a, int b)
    {
        return _arr[a].CompareTo(_arr[b]) < 0;
    }

    private void Sink(int k)
    {
        while (2 * k <= _N)
        {
            var j = 2 * k;
            if (j < _N && Less(j, j + 1)) j++;
            if (!Less(k, j)) break;
            (_arr[k], _arr[j]) = (_arr[j], _arr[k]);
            k = j;
        }
    }
}