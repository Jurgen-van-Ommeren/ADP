namespace ADP.Trees;

public class AvlTreeTest
{
    public void Run()
    {
        var avlTree = new AvlTree();
        // avlTree.Insert(1);
        // avlTree.Insert(2);
        // avlTree.Insert(3);
        
        avlTree.Insert(12);
        avlTree.Insert(16);
        avlTree.Insert(8);
        avlTree.Insert(14);
        avlTree.Insert(10);
        avlTree.Insert(4);
        avlTree.Insert(2);
        avlTree.Insert(6);

        var draft = avlTree;
        
        avlTree.Insert(5);
    }
}