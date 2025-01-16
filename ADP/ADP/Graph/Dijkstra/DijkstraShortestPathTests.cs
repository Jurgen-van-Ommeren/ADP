using System.Diagnostics;
using ADP.Dataset;
using ADP.Testing;

namespace ADP.Graph.Dijkstra;

public class DijkstraShortestPathTests
{
   public void Run(DatasetGraphs datasetGraphs)
    {
        //warmup
        var graph = new Graph();
        graph.PopulateFromWeightedAdjacencyList(datasetGraphs.verbindingslijst_gewogen);
        DijkstraShortestPathSolution.FindShortestPaths(graph, "0");
        
        long total100 = 0;
        for (int i = 0; i < 1000; i++)
        {
            total100 += TestDijkstra1000();
        }
        Console.WriteLine($"Test Dijkstra met 1000 edges duurde {total100 / 1000} ticks");

        long total1000 = 0;
        for (int i = 0; i < 1000; i++)
        {
            total1000 += TestDijkstra10000();
        }
        Console.WriteLine($"Test Dijkstra met 10000 edges duurde {total1000 / 1000} ticks");

        long TestDijkstra1000()
        {
            var list = CreateLijnlijstGewogen(1000, 100);
            var testGraph = new Graph();
            testGraph.PopulateFromWeightedEdgeList(list);

            var sw = new Stopwatch();
            sw.Start();
            DijkstraShortestPathSolution.FindShortestPaths(testGraph, "0");
            sw.Stop();

            return sw.ElapsedTicks;
        }
        
        long TestDijkstra10000()
        {
            var list10000 = CreateLijnlijstGewogen(10000, 100);
            var testGraph10000 = new Graph();
            testGraph10000.PopulateFromWeightedEdgeList(list10000);

            var sw = new Stopwatch();
            sw.Start();
            DijkstraShortestPathSolution.FindShortestPaths(testGraph10000, "0");
            sw.Stop();

            return sw.ElapsedTicks;
        }
    }

    private static int[][] CreateLijnlijstGewogen(int numberOfRows, int maxEdgeWeight)
    {
        Random random = new Random();
        int[][] data = new int[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            int startNode = random.Next(0, 10); // Random start node (adjust range as needed)
            int endNode = random.Next(0, 10);   // Random end node (adjust range as needed)
            int weight = random.Next(1, maxEdgeWeight + 1); // Random weight between 1 and maxEdgeWeight

            data[i] = new int[] { startNode, endNode, weight };
        }

        return data;
    }
}