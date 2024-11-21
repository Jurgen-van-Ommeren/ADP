namespace ADP.Operations.DynamicArray;

public class DynamicArrayTests
{
    public void TestAddFunction()
    {
        var array = new DynamicArray<string>
        {
            "hallo",
            "Ola",
            "Hello",
            "Hi",
            "joo"
        };

        var array2 = new DynamicArray<int>(8);
        array2.Add(1);
        array2.Add(2);
        array2.Add(3);
        array2.Add(4);
        array2.Add(5);
        array2.Add(6);
        array2.Add(7);
        array2.Add(8);
        array2.Add(9);

        foreach (var item in array)
        {
            Console.WriteLine($"array: {item}");
        }

        foreach (var item in array2)
        {
            Console.WriteLine($"array2: {item}");
        }
    }

    public void TestGetFunction()
    {
        var array = GetTestArray();

        Console.WriteLine($"index: 2 {array.Get(2)}");
        Console.WriteLine($"index: 5 {array.Get(5)}");
    }

    public void TestSetFunction()
    {
        var array = GetTestArray();

        Console.WriteLine($"index: 2 {array.Get(2)}");

        Console.WriteLine("Set index 2 to: Bye");

        array.Set(2, "Bye");

        Console.WriteLine($"index: 2 {array.Get(2)}");


        Console.WriteLine($"index: 8 {array.Get(8)}");

        Console.WriteLine("Set index 8 to: Bye");

        array.Set(8, "Bye");

        Console.WriteLine($"index: 8 {array.Get(8)}");
    }

    public void TestRemoveFunction()
    {
        var array = GetTestArray();

        Console.WriteLine("Original array:");

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("remove index 2");

        array.Remove(2);

        Console.WriteLine("");
        Console.WriteLine("New array:");

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    public void TestRemoveElementFunction()
    {
        var array = GetTestArray();

        var testString = "hello";
        
        array.Add(testString);
        
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        
        array.Remove(testString);
        
        Console.WriteLine();
        
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
    
    public void TestContainsFunction()
    {
        var array = GetTestArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine($"Array contains 'Hello': {array.Contains("Hello")}");
        Console.WriteLine($"Array contains 'Jooo': {array.Contains("Jooo")}");
    }
    
    public void TestIndexOfFunction()
    {
        var array = GetTestArray();

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Console.WriteLine($"index of 'Hello': {array.IndexOf("Hello")}");
        Console.WriteLine($"index of 'Jooo': {array.IndexOf("Jooo")}");
    }

    private DynamicArray<string> GetTestArray()
    {
        return new DynamicArray<string>
        {
            "hallo",
            "Ola",
            "Hello",
            "Hi",
            "joo"
        };
    }
}