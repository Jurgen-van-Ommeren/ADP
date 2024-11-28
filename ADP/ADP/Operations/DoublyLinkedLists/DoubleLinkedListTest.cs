using System.Text.Json;
using ADP.Dataset;
using ADP.Testing;
using ADP.TestObjects;

namespace ADP.Operations.DoublyLinkedLists;

public class DoubleLinkedListTest
{
    public void Run(DatasetSorting datasetSorting)
    {
        Add();
        GetAndSetAndRemoveOnIndex();
        RemoveAndContainsByInstance();
        IndexOf();
        Pizzas(datasetSorting);
    }

    private void Add()
    {
        //In next loops we add three times 1_000_000
        //Adding takes the same time because Add is constant because complexity O(1)
        
        var doubleLinkedList = new DoubleLinkedList<string>();
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        doubleLinkedList.Add(Guid.NewGuid().ToString());

        ConsoleStopwatch.Start("Adding 1_000_000"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            doubleLinkedList.Add(Guid.NewGuid().ToString());
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Adding 1_000_000"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            doubleLinkedList.Add(Guid.NewGuid().ToString());
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Adding 1_000_000"); 
        for (int i = 0; i < 1_000_000; i++)
        {
            doubleLinkedList.Add(Guid.NewGuid().ToString());
        }
        ConsoleStopwatch.Stop();
    }

    private void GetAndSetAndRemoveOnIndex()
    {
        //Underneath we do four gets, sets and removes with different indexes
        //The time is linear because Get, Set and Remove has complexity O(N)
        //But actually O(1/2N) because index lookup wil start at end if wanted index is more than half of size
        
        var doubleLinkedList = new DoubleLinkedList<string>();
        
        for (int i = 0; i < 1_000_000; i++)
            doubleLinkedList.Add(Guid.NewGuid().ToString());
        
        //Warmup
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        doubleLinkedList.Get(0);
        doubleLinkedList.Set(0, Guid.NewGuid().ToString());
        doubleLinkedList.Remove(0);
        
        ConsoleStopwatch.Start("Get 499_000");
        doubleLinkedList.Get(499_000);
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Set 499_000");
        doubleLinkedList.Set(499_000, Guid.NewGuid().ToString());
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 499_000");
        doubleLinkedList.Remove(499_000);
        ConsoleStopwatch.Stop();
        
        //Same time as 499_000
        ConsoleStopwatch.Start("Get 501_000");
        doubleLinkedList.Get(501_000);
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Set 501_000");
        doubleLinkedList.Set(501_000, Guid.NewGuid().ToString());
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 501_000");
        doubleLinkedList.Remove(501_000);
        ConsoleStopwatch.Stop();
        
        //Till here...
        ConsoleStopwatch.Start("Get 100");
        doubleLinkedList.Get(100);
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Set 100");
        doubleLinkedList.Set(100, Guid.NewGuid().ToString());
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 100");
        doubleLinkedList.Remove(100);
        ConsoleStopwatch.Stop();
        
        //Same time as 100
        ConsoleStopwatch.Start("Get 999_900");
        doubleLinkedList.Get(999_900);
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Set 999_900");
        doubleLinkedList.Set(999_900, Guid.NewGuid().ToString());
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 999_900");
        doubleLinkedList.Remove(999_900);
        ConsoleStopwatch.Stop();
    }

    private void RemoveAndContainsByInstance()
    {
        //Underneath we do three contains and removes with different string values
        //The time is linear because Constains and Remove has complexity O(N)
        
        var doubleLinkedList = new DoubleLinkedList<string>();
        
        for (int i = 0; i < 1_000_000; i++)
            doubleLinkedList.Add(i.ToString());
        
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        doubleLinkedList.Contains("5");
        doubleLinkedList.Remove("1");
        
        ConsoleStopwatch.Start("Contains 5");
        doubleLinkedList.Contains("5");
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 5");
        doubleLinkedList.Remove("5");
        ConsoleStopwatch.Stop();
        
        //Takes 100000x more time than 5
        ConsoleStopwatch.Start("Contains 500000");
        doubleLinkedList.Contains("500000");
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 500000");
        doubleLinkedList.Remove("500000");
        ConsoleStopwatch.Stop();
        
        //Takes twice more time than 500000
        ConsoleStopwatch.Start("Contains 999999");
        doubleLinkedList.Contains("999999");
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("Remove 999999");
        doubleLinkedList.Remove("999999");
        ConsoleStopwatch.Stop();
    }

    private void IndexOf()
    {
        //Underneath we do three IndexOf with different string values
        //The time is linear because IndexOf has complexity O(N) 
        //As longs as the IComparable implementation doesn't use loops
        
        var doubleLinkedList = new DoubleLinkedList<string>();
        
        for (int i = 0; i < 1_000_000; i++)
            doubleLinkedList.Add(i.ToString());
        
        ConsoleStopwatch.Start("Warmup");
        ConsoleStopwatch.Stop();
        doubleLinkedList.IndexOf("1");
        
        ConsoleStopwatch.Start("IndexOf 5");
        doubleLinkedList.IndexOf("5");
        ConsoleStopwatch.Stop();
        
        //Takes 100000x more time than 5
        ConsoleStopwatch.Start("IndexOf 500000");
        doubleLinkedList.IndexOf("500000");
        ConsoleStopwatch.Stop();
        
        //Takes twice more time than 500000
        ConsoleStopwatch.Start("IndexOf 999999");
        doubleLinkedList.IndexOf("999999");
        ConsoleStopwatch.Stop();
    }

    private void Pizzas(DatasetSorting datasetSorting)
    {
        //Match pizza on slices, compare logic is implemented in Pizza class.
        
        var doubleLinkedList = new DoubleLinkedList<Pizza>();
        
        foreach (var pizza in datasetSorting.Pizzas)
            doubleLinkedList.Add(pizza);

        var targetPizza = new Pizza
        {
            Name = "Margherita",
            Slices = 5
        };
        
        Console.WriteLine(doubleLinkedList.Contains(targetPizza));

        var indexOfPizza = doubleLinkedList.IndexOf(targetPizza);
        Console.WriteLine(indexOfPizza);
        
        //Writes pizza with 5 slices
        Console.WriteLine(JsonSerializer.Serialize(doubleLinkedList.Get(indexOfPizza)));
        
        doubleLinkedList.Remove(targetPizza);
        Console.WriteLine(doubleLinkedList.IndexOf(targetPizza));
    }
}