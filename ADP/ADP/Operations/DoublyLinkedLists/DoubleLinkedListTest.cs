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

        // doubleLinkedList.Remove(0);
        // doubleLinkedList.Contains("Een");
        // doubleLinkedList.IndexOf("Een");
        // doubleLinkedList.Set(1, "Twee");


        // doubleLinkedList.Add("Een");
        // doubleLinkedList.Add("Twee");
        // doubleLinkedList.Add("Drie");
        // doubleLinkedList.Add("Vier");
        // doubleLinkedList.Add("Vijf");
        //
        // doubleLinkedList.Set(0, "Half");
        // Console.WriteLine(doubleLinkedList.Get(0));
        //
        // doubleLinkedList.Set(2, "Drie en half");
        // Console.WriteLine(doubleLinkedList.Get(2));
        //
        // doubleLinkedList.Set(4, "Vijf en half");
        // Console.WriteLine(doubleLinkedList.Get(4));
        //
        // doubleLinkedList.Remove(0);
        // doubleLinkedList.Remove(1);
        // doubleLinkedList.Remove(2);
        //
        // doubleLinkedList.Add("Zes");
        // doubleLinkedList.Add("Zeven");
        // doubleLinkedList.Add("Zeven komma 2");
        // doubleLinkedList.Add("Acht");
        //
        // doubleLinkedList.Remove("Zeven komma 2");
        //
        // Console.WriteLine(doubleLinkedList.Contains("Zeven komma 2"));
        // Console.WriteLine(doubleLinkedList.Contains("Acht"));
        //
        // Console.WriteLine(doubleLinkedList.IndexOf("Een"));
        // Console.WriteLine(doubleLinkedList.IndexOf("Vijf"));
        // Console.WriteLine(doubleLinkedList.IndexOf("Zeven"));
    }
}