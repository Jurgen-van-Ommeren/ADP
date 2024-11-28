using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.DoublyLinkedLists;

public class DoubleLinkedListTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var doubleLinkedList = new DoubleLinkedList<int>();
        
        ConsoleStopwatch.Start("Adding 1000000"); 
        for (int i = 0; i < 1000000; i++)
        {
            doubleLinkedList.Add(i);
        }
        ConsoleStopwatch.Stop();
        
        doubleLinkedList = new DoubleLinkedList<int>();
        
        ConsoleStopwatch.Start("Adding 2000000"); 
        for (int i = 0; i < 2000000; i++)
        {
            doubleLinkedList.Add(i);
        }
        ConsoleStopwatch.Stop();
        
        doubleLinkedList = new DoubleLinkedList<int>();
        
        ConsoleStopwatch.Start("Adding 10000000"); 
        for (int i = 0; i < 10_000_000; i++)
        {
            doubleLinkedList.Add(i);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Get 1 in middle");
        for (int i = 0; i < 1; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Get 2 in middle");
        for (int i = 0; i < 2; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        ConsoleStopwatch.Stop();

        ConsoleStopwatch.Start("Get 10 in middle");
        for (int i = 0; i < 10; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        ConsoleStopwatch.Stop();
    }
}