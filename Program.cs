namespace homework25;

class Program
{
    static void Main()
    {
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("Count: " + list.Count);
        Console.WriteLine("First: " + list.First.Value);
        Console.WriteLine("Last: " + list.Last.Value);
    }
}