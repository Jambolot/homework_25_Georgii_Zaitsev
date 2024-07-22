namespace homework25;

public class MyLinkedList<T>
{
    private MyNode<T> head;
    private MyNode<T> tail;
    private int count;
    public MyLinkedList()
    {
        head = null;
        tail = null;
        count = 0;
    }
    public MyNode<T> Add(T element)
    {
        var newNode = new MyNode<T>(element);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
        count++;
        return newNode;
    }
    public int Count
    {
        get { return count; }
    }
    public MyNode<T> First
    {
        get { return head; }
    }
    public MyNode<T> Last
    {
        get { return tail; }
    }
}