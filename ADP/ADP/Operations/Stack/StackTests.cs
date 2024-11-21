namespace ADP.ADT_Operations.Stack;

public class StackTests
{
    public void TestStack()
    {
        var stack = CreateTestStack();
        
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        
        stack.Push("doei");
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());
    }
    
    private Stack<string> CreateTestStack()
    {
        var stack = new Stack<string>();
        
        stack.Push("hallo");
        stack.Push("Jo");
        stack.Push("goedemiddag");
        stack.Push("goedenavond");
        stack.Push("goede nacht");

        return stack;
    }
}