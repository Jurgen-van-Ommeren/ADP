namespace ADP.Operations.PriorityQueue;

public class PriorityQueueTests
{
    

    public void Run()
    {
        var priorityQueue = new PriorityQueue<string>();
        
        priorityQueue.Add("aa");
        priorityQueue.Add("bb");
        priorityQueue.Add("dd");
        priorityQueue.Add("cc");

        Console.WriteLine(priorityQueue.Peek());
        Console.WriteLine(priorityQueue.Poll());
        Console.WriteLine(priorityQueue.Peek());
        Console.WriteLine(priorityQueue.Poll());
        Console.WriteLine(priorityQueue.Peek());
        Console.WriteLine(priorityQueue.Poll());
        Console.WriteLine(priorityQueue.Peek());
        Console.WriteLine(priorityQueue.Poll());
    }
}