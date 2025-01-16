using ADP.Dataset;
using ADP.Graph.GraphParts;

namespace ADP.Graph;

public class GraphTests
{
    public void Run(DatasetGraphs datasetGraphs)
    {
        CheckEdgeList(datasetGraphs);
        
        CheckAdjacencyList(datasetGraphs);
        
        CheckAdjacencyMatrix(datasetGraphs);
        
        CheckWeightedEdgeList(datasetGraphs);
        
        CheckWeightedAdjacencyList(datasetGraphs);

        CheckWeightedAdjacencyMatrix(datasetGraphs);

        CheckDeleteEdgeFunction(datasetGraphs);

        CheckDeleteVertexFunction(datasetGraphs);
    }

    private void CheckDeleteEdgeFunction(DatasetGraphs datasetGraphs)
    {
        var graph = new Graph();
        graph.PopulateFromAdjacencyList(datasetGraphs.verbindingslijst);

        var edge = new Edge(new Vertex("test"), 1);
        
        graph.RemoveEdge("1", edge);
    }
    
    private void CheckDeleteVertexFunction(DatasetGraphs datasetGraphs)
    {
        var graph = new Graph();
        graph.PopulateFromAdjacencyList(datasetGraphs.verbindingslijst);
        
        graph.RemoveVertex("1");
    }

    private void CheckEdgeList(DatasetGraphs datasetGraphs)
    {
        var graphEdgelist = new Graph();
        graphEdgelist.PopulateFromEdgeList(datasetGraphs.lijnlijst);

        var vertex = graphEdgelist.GetVertex("0");

        if (vertex.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij lijnlijst");
        }

        if (vertex.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij lijnlijst");
        }
        
        Console.WriteLine("lijnlijst gaat goed");
    }

    private void CheckAdjacencyList(DatasetGraphs datasetGraphs)
    {
        var graphAdjacencyList = new Graph();
        graphAdjacencyList.PopulateFromAdjacencyList(datasetGraphs.verbindingslijst);
        
        var vertex = graphAdjacencyList.GetVertex("0");
        
        if (vertex.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij verbindingslijst");
        }

        if (vertex.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij verbindingslijst");
        }
        
        Console.WriteLine("verbindingslijst gaat goed");
    }

    private void CheckAdjacencyMatrix(DatasetGraphs datasetGraphs)
    {
        var graphAdjacencyMatrix = new Graph();
        graphAdjacencyMatrix.PopulateFromAdjacencyMatrix(datasetGraphs.verbindingsmatrix);
        
        var vertex0 = graphAdjacencyMatrix.GetVertex("0");
        var vertex1 = graphAdjacencyMatrix.GetVertex("1");
        
        if (vertex0.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij verbindingsmatrix");
        }

        if (vertex0.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij verbindingsmatrix");
        }
        
        if (vertex1.AdjacentEdges[0].Destination.Name != "0")
        {
            Console.WriteLine("Fout bij verbindingsmatrix");
        }
        
        Console.WriteLine("verbindingsmatrix gaat goed");
    }

    private void CheckWeightedEdgeList(DatasetGraphs datasetGraphs)
    {
        var graphWeightedEdgeList = new Graph();
        graphWeightedEdgeList.PopulateFromWeightedEdgeList(datasetGraphs.lijnlijst_gewogen);

        var vertex = graphWeightedEdgeList.GetVertex("0");

        if (vertex.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij lijnlijst_gewogen");
        }

        if (vertex.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij lijnlijst_gewogen");
        }
        
        if (vertex.AdjacentEdges[0].Cost != 99.0d)
        {
            Console.WriteLine("Fout bij lijnlijst_gewogen");
        }
        
        Console.WriteLine("lijnlijst_gewogen gaat goed");
    }

    private void CheckWeightedAdjacencyList(DatasetGraphs datasetGraphs)
    {
        var graphWeightedAdjacencyList = new Graph();
        graphWeightedAdjacencyList.PopulateFromWeightedAdjacencyList(datasetGraphs.verbindingslijst_gewogen);
        
        var vertex = graphWeightedAdjacencyList.GetVertex("0");

        if (vertex.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij verbindingslijst_gewogen");
        }

        if (vertex.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij verbindingslijst_gewogen");
        }
        
        if (vertex.AdjacentEdges[0].Cost != 99.0d)
        {
            Console.WriteLine("Fout bij verbindingslijst_gewogen");
        }
        
        Console.WriteLine("verbindingslijst_gewogen gaat goed");
    }

    private void CheckWeightedAdjacencyMatrix(DatasetGraphs datasetGraphs)
    {
        var graphWeightedAdjacencyMatrix = new Graph();
        graphWeightedAdjacencyMatrix.PopulateFromWeightedAdjacencyMatrix(datasetGraphs.verbindingsmatrix_gewogen);
        
        var vertex0 = graphWeightedAdjacencyMatrix.GetVertex("0");
        var vertex1 = graphWeightedAdjacencyMatrix.GetVertex("1");
        
        if (vertex0.AdjacentEdges.Count != 2)
        {
            Console.WriteLine("Fout bij verbindingsmatrix_gewogen");
        }

        if (vertex0.AdjacentEdges[0].Destination.Name != "1")
        {
            Console.WriteLine("Fout bij verbindingsmatrix_gewogen");
        }
        
        if (vertex0.AdjacentEdges[0].Cost != 99d)
        {
            Console.WriteLine("Fout bij verbindingsmatrix_gewogen");
        }
        
        if (vertex1.AdjacentEdges[0].Destination.Name != "2")
        {
            Console.WriteLine("Fout bij verbindingsmatrix_gewogen");
        }
        
        if (vertex1.AdjacentEdges[0].Cost!= 50d)
        {
            Console.WriteLine("Fout bij verbindingsmatrix_gewogen");
        }
        
        Console.WriteLine("verbindingsmatrix_gewogen gaat goed");
    }
}