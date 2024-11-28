using ADP.Dataset;
using ADP.Testing;
using ADP.TestObjects;

namespace ADP.Operations.DynamicArray;

public class DynamicArrayTests
{
    public void Run(DatasetSorting datasetSorting)
    {
        var array = new DynamicArray<float>(8002);
        var pizzaArray = new DynamicArray<Pizza>(8002);
        
        //complexity: O N, because on resizing it needs to copy the whole array to the new array
        //takes 12883 ticks
        ConsoleStopwatch.Start("adding LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("adding pizzas");
        foreach (var item in datasetSorting.Pizzas)
        {
            pizzaArray.Add(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O, because the index directly references to the place where the data is stored.
        //takes 3636 ticks
        ConsoleStopwatch.Start("getting LijstFloat8001");
        for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            array.Get(i);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O, because the index directly references to the place where the data will be stored.
        //takes 2761 ticks
        ConsoleStopwatch.Start("setting LijstFloat8001");
        for (var i = 0; i < datasetSorting.LijstFloat8001.Length; i++)
        {
            array.Set(i, datasetSorting.LijstFloat8001[i]);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N, because there is 1 loop, the iterations it takes to find the item grows linear with the amount of items.
        // takes 16986 ticks
        ConsoleStopwatch.Start("contains LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Contains(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("containing pizzas");
        foreach (var item in datasetSorting.Pizzas)
        {
            pizzaArray.Contains(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N, because there is 1 loop, the iterations it takes to find the item grows linear with the amount of items.
        // takes 17029 ticks
        ConsoleStopwatch.Start("index of LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.IndexOf(item);
        }
        ConsoleStopwatch.Stop();
        
        //complexity: O N^2, because there is 1 loop for comparing the items and 1 loop for swiping the array
        // takes 4198643 ticks
        ConsoleStopwatch.Start("remove item from LijstFloat8001");
        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Remove(item);
        }
        ConsoleStopwatch.Stop();
        
        ConsoleStopwatch.Start("removing pizzas");
        foreach (var item in datasetSorting.Pizzas)
        {
            pizzaArray.Remove(item);
        }
        ConsoleStopwatch.Stop();

        foreach (var item in datasetSorting.LijstFloat8001)
        {
            array.Add(item);
        }
        
        //complexity: O N, because there is 1 loop for swiping the array
        //takes 2756 ticks
        ConsoleStopwatch.Start("removing by index LijstFloat8001");
        for (var i = datasetSorting.LijstFloat8001.Length - 1; i > 0; i--)
        {
            array.Remove(i);
        }
        ConsoleStopwatch.Stop();
        

    }
}