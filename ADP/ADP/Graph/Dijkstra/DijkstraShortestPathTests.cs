using ADP.Dataset;

namespace ADP.Graph.Dijkstra;

public class DijkstraShortestPathTests
{
   public void Run(DatasetGraphs datasetGraphs)
    {
        var graph = new Graph();
        graph.PopulateFromWeightedAdjacencyList(datasetGraphs.verbindingslijst_gewogen);
        
        DijkstraShortestPathSolution.GetDistance(graph, "0", "4");
    }
}