namespace ADP.Graph.GraphParts;

public class Edge
{
    public Edge(Vertex destination, double cost)
    {
        Destination = destination;
        Cost = cost;
    }
    
    public Vertex Destination { get; }
    public double Cost { get; }
}