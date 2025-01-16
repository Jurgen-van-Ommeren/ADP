namespace ADP.Trees;

public class AVLNode
{
    public int Value { get; set; }
    public AVLNode Left { get; set; }
    public AVLNode Right { get; set; }

    public int Height { get; set; }
    public int BalanceFactor { get; set; }
    
}