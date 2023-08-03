namespace Solutions.Chapter1.Section3;

public class S40
{
    public List<string> Sequence { get; set; } = new();
    public LinkedList<string> SequenceByLinkedList { get; set; } = new();

    public void MoveToFront(string x)
    {
        if (Sequence.Contains(x))
        {
            Sequence.Remove(x);
            Sequence.Insert(0, x);
            return;
        }
        Sequence.Insert(0, x);
    }

    public void MoveToFrontByLinkedList(string x)
    {
        LinkedListNode<string>? node = SequenceByLinkedList.Find(x);

        if (node != null)
        {
            SequenceByLinkedList.Remove(node);
        }

        SequenceByLinkedList.AddFirst(x);
    }
}