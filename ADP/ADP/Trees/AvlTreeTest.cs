using System.Diagnostics;

namespace ADP.Trees;

public class AvlTreeTest
{
    public void Run()
    {
        TestAVLTree1000();

        TestAVLTree10000();
    }

    private void TestAVLTree1000()
    {
        var avlTree = new AvlTree();
        Random random = new Random();
        var sw = new Stopwatch();

        var usedNumbers = new List<int>();

        while (usedNumbers.Count < 1000)
        {
            var number = random.Next(0, 1000);

            if (!usedNumbers.Contains(number))
            {
                usedNumbers.Add(number);
                avlTree.Insert(number);
            }
        }

        long total = 0;
        for (int i = 0; i < 1000; i++)
        {
            sw.Start();
            avlTree.Find(i);
            sw.Stop();
            total += sw.ElapsedTicks;
            sw.Reset();
        }

        Console.WriteLine($"average time with 1000 items = {total / 1000} ticks");
    }

    private void TestAVLTree10000()
    {
        var avlTree = new AvlTree();
        var random = new Random();
        var sw = new Stopwatch();

        var usedNumbers = new List<int>();

        while (usedNumbers.Count < 10000)
        {
            var number = random.Next(0, 10000);

            if (usedNumbers.Contains(number))
                continue;

            usedNumbers.Add(number);
            avlTree.Insert(number);
        }

        long total = 0;
        for (int i = 0; i < 10000; i++)
        {
            sw.Start();
            avlTree.Find(i);
            sw.Stop();
            total += sw.ElapsedTicks;
            sw.Reset();
        }

        Console.WriteLine($"average time with 10000 items = {total / 10000} ticks");
    }

    static int GetUniqueRandomNumber(HashSet<int> usedNumbers, int minValue, int maxValue, int amount)
    {
        Random random = new Random();
        int number;

        do
        {
            number = random.Next(minValue, maxValue);
        } while (usedNumbers.Count < amount);

        usedNumbers.Add(number);
        return number;
    }
}