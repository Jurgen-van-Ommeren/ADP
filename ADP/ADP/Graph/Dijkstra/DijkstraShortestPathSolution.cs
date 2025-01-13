using ADP.Graph.GraphParts;

namespace ADP.Graph.Dijkstra;

public static class DijkstraShortestPathSolution
{
    public static (Dictionary<string, double> Distances, Dictionary<string, string> Predecessors) FindShortestPaths(Graph graph, string startVertexName)
    {
        if (!graph.GetVertexMap().ContainsKey(startVertexName))
        {
            throw new ArgumentException($"Vertex '{startVertexName}' does not exist in the graph.");
        }

        var distances = new Dictionary<string, double>();
        var predecessors = new Dictionary<string, string>();
        var priorityQueue = new HashSet<string>();

        foreach (var vertex in graph.GetVertexMap().Keys)
        {
            distances[vertex] = double.PositiveInfinity;
            predecessors[vertex] = null;
        }
        distances[startVertexName] = 0;

        foreach (var vertex in graph.GetVertexMap().Keys)
        {
            priorityQueue.Add(vertex);
        }

        while (priorityQueue.Count > 0)
        {
            string currentVertexName = null;
            var smallestDistance = double.PositiveInfinity;

            foreach (var vertex in priorityQueue)
            {
                if (!(distances[vertex] < smallestDistance)) 
                    continue;
                
                smallestDistance = distances[vertex];
                currentVertexName = vertex;
            }

            if (currentVertexName == null) break;

            priorityQueue.Remove(currentVertexName);

            var currentVertex = graph.GetVertexMap()[currentVertexName];
            
            CheckConnectedVertexes(currentVertex);
        }

        return (distances, predecessors);

        void CheckConnectedVertexes(Vertex vertex)
        {
            foreach (var edge in vertex.AdjacentEdges)
            {
                var neighbor = edge.Destination;
                var newDistance = distances[vertex.Name] + edge.Cost;

                if (!(newDistance < distances[neighbor.Name])) 
                    continue;
                
                distances[neighbor.Name] = newDistance;
                predecessors[neighbor.Name] = vertex.Name;
            }
        }
    }
    
    public static void GetDistance(Graph graph, string startVertexName, string destinationVertexName)
    {
        Dictionary<string, double> distances;
        Dictionary<string, string> predecessors;
        
        (distances, predecessors) = FindShortestPaths(graph, startVertexName);
        
        var distance = distances[destinationVertexName];
        
        Console.WriteLine($"distance: {distance}");
        PrintPath(startVertexName, destinationVertexName, predecessors);
    }
    
    private static void PrintPath(string startVertex, string endVertex, Dictionary<string, string> predecessors)
    {
        var path = new List<string>();
        var currentVertex = endVertex;

        // Backtrack from the destination to the start
        while (currentVertex != null)
        {
            path.Add(currentVertex);
            currentVertex = predecessors[currentVertex];
        }

        path.Reverse(); // Reverse the path to show it from start to end

        // Check if the start vertex is reachable
        if (path.First() != startVertex)
        {
            Console.WriteLine($"No path exists from {startVertex} to {endVertex}");
        }
        else
        {
            Console.WriteLine($"Path from {startVertex} to {endVertex}: {string.Join(" -> ", path)}");
        }
    }
}