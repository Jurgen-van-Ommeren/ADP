using ADP.Graph.Dijkstra;
using ADP.Graph.GraphParts;

namespace ADP.Graph;

public class Graph
{
    private Dictionary<string,Vertex> _vertexMap = new();

    public Vertex GetVertex(string vertexName)
    {
        return _vertexMap[vertexName];
    }

    public void AddVertex(string name)
    {
        if (!_vertexMap.ContainsKey(name))
        {
            _vertexMap[name] = new Vertex(name);
        }
    }

    public void RemoveVertex(string name)
    {
        if (!_vertexMap.TryGetValue(name, out var vertex))
        {
            return;
        }

        _vertexMap.Remove(vertex.Name);
        
        foreach (var vertexMapValue in _vertexMap.Values)
        {
            foreach (var edge in vertexMapValue.AdjacentEdges.Where(x => x.Destination.Name == vertex.Name).ToList())
            {
                vertexMapValue.AdjacentEdges.Remove(edge);
            }
        }
    }
    
    public Dictionary<string, Vertex> GetVertexMap()
    {
        return _vertexMap;
    }
    
    public void AddEdge(string sourceName, string destinationName, double cost = 1.0)
    {
        if (!_vertexMap.ContainsKey(sourceName))
        {
            AddVertex(sourceName);
        }

        if (!_vertexMap.ContainsKey(destinationName))
        {
            AddVertex(destinationName);
        }

        var source = _vertexMap[sourceName];
        var destination = _vertexMap[destinationName];

        source.AddEdge(destination, cost);
    }
    
    public void RemoveEdge(string sourceName, Edge edge)
    {
        if (!_vertexMap.TryGetValue(sourceName, out var source))
        {
            return;
        }

        source.RemoveEdge(edge);
    }
    
    public void PopulateFromEdgeList(int[][] edgeList)
    {
        foreach (var edge in edgeList)
        {
            var source = edge[0].ToString();
            var destination = edge[1].ToString();
            AddEdge(source, destination);
        }
    }

    public void PopulateFromAdjacencyList(int[][] adjacencyList)
    {
        for (var i = 0; i < adjacencyList.Length; i++)
        {
            var source = i.ToString();
            AddVertex(source);

            foreach (var destinationIndex in adjacencyList[i])
            {
                var destination = destinationIndex.ToString();
                AddEdge(source, destination);
            }
        }
    }
    
     public void PopulateFromAdjacencyMatrix(int[][] adjacencyMatrix)
    {
        int size = adjacencyMatrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            string source = i.ToString();
            AddVertex(source);

            for (int j = 0; j < size; j++)
            {
                if (adjacencyMatrix[i][j] == 1)
                {
                    string destination = j.ToString();
                    AddEdge(source, destination);
                }
            }
        }
    }

    public void PopulateFromWeightedEdgeList(int[][] weightedEdgeList)
    {
        foreach (var edge in weightedEdgeList)
        {
            string source = edge[0].ToString();
            string destination = edge[1].ToString();
            double cost = edge[2];
            AddEdge(source, destination, cost);
        }
    }

    public void PopulateFromWeightedAdjacencyList(int[][][]weightedAdjacencyList)
    {
        for (int i = 0; i < weightedAdjacencyList.Length; i++)
        {
            string source = i.ToString();
            AddVertex(source);

            foreach (var connection in weightedAdjacencyList[i])
            {
                string destination = connection[0].ToString();
                double cost = connection[1];
                AddEdge(source, destination, cost);
            }
        }
    }

    public void PopulateFromWeightedAdjacencyMatrix(int[][] weightedAdjacencyMatrix)
    {
        int size = weightedAdjacencyMatrix.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            string source = i.ToString();
            AddVertex(source);

            for (int j = 0; j < size; j++)
            {
                if (weightedAdjacencyMatrix[i][j] > 0)
                {
                    string destination = j.ToString();
                    double cost = weightedAdjacencyMatrix[i][j];
                    AddEdge(source, destination, cost);
                }
            }
        }
    }
}