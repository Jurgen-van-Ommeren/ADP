namespace ADP.Graph.GraphParts;

public class Vertex
{
    public string Name { get; }
    public List<Edge> AdjacentEdges { get; }
    
    public Vertex(string name)
    {
        Name = name;
        AdjacentEdges = new List<Edge>();
    }
    
    public void AddEdge(Vertex destination, double cost)
    {
        AdjacentEdges.Add(new Edge(destination, cost));
    }
    
    public void RemoveEdge(Edge edge)
    {
        AdjacentEdges.Remove(edge);
    }
    
    //TODO remove function
}