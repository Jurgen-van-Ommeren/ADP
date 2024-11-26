using ADP.Dataset;
using ADP.Testing;

namespace ADP.Operations.DoublyLinkedLists;

public class DoubleLinkedListTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        var sw = new ConsoleStopwatch();
        
        var doubleLinkedList = new DoubleLinkedList<int>();
        
        sw.Start("Adding 1000000"); 
        for (int i = 0; i < 1000000; i++)
        {
            doubleLinkedList.Add(i);
        }
        sw.Stop();
        
        doubleLinkedList = new DoubleLinkedList<int>();
        
        sw.Start("Adding 2000000"); 
        for (int i = 0; i < 2000000; i++)
        {
            doubleLinkedList.Add(i);
        }
        sw.Stop();
        
        doubleLinkedList = new DoubleLinkedList<int>();
        
        sw.Start("Adding 10000000"); 
        for (int i = 0; i < 10_000_000; i++)
        {
            doubleLinkedList.Add(i);
        }
        sw.Stop();
        
        sw.Start("Get 1 in middle");
        for (int i = 0; i < 1; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        sw.Stop();
        
        sw.Start("Get 2 in middle");
        for (int i = 0; i < 2; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        sw.Stop();

        sw.Start("Get 10 in middle");
        for (int i = 0; i < 10; i++)
        {
            doubleLinkedList.Get(i + 5_000_000);
        }
        sw.Stop();
    }
}