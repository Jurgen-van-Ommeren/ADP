namespace ADP.Trees;

public class AvlTree
{
    public AVLNode Root { get; set; }

    public void Insert(int value)
    {
        var newNode = new AVLNode()
        {
            Value = value
        };

        if (Root == null)
        {
            Root = newNode;

            return;
        }

        var currentNode = Root;

        while (true)
        {
            if (currentNode.Value == value)
                throw new Exception();

            if (currentNode.Value > value)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    break;
                }

                currentNode = currentNode.Left;
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    break;
                }

                currentNode = currentNode.Right;
            }
        }

        CheckTreeBalance();
    }

    public int FindMin()
    {
        return FindMinInternal(Root)?.Value ?? 0;
    }

    public int FindMax()
    {
        if (Root == null)
        {
            return 0;
        }

        var currentNode = Root;

        while (currentNode.Right != null)
        {
            currentNode = currentNode.Right;
        }

        return currentNode.Value;
    }

    public AVLNode Find(int value)
    {
        var currentNode = Root;

        while (currentNode != null)
        {
            if (currentNode.Value == value)
            {
                return currentNode;
            }

            if (currentNode.Value > value)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        return null;
    }

    public void Remove(int value)
    {
        var matchedNode = Root;
        AVLNode parentNode = null;

        while (matchedNode != null)
        {
            if (matchedNode.Value == value)
            {
                break;
            }

            parentNode = matchedNode;

            if (matchedNode.Value > value)
            {
                matchedNode = matchedNode.Left;
            }
            else
            {
                matchedNode = matchedNode.Right;
            }
        }

        if (matchedNode == null)
        {
            return;
        }

        if (
            matchedNode.Left == null &&
            matchedNode.Right == null
        )
        {
            DeleteLeafNode(matchedNode, parentNode);
            return;
        }

        if (matchedNode.Left == null || matchedNode.Right == null)
        {
            DeleteNodeWithOneChild(matchedNode, parentNode);
            return;
        }

        DeleteNodeWithTwoChildren(matchedNode);
        CheckTreeBalance();
    }

    private void DeleteLeafNode(AVLNode nodeToDelete, AVLNode parentNode)
    {
        if (parentNode == null)
        {
            Root = nodeToDelete;
            return;
        }

        if (parentNode.Left?.Value == nodeToDelete.Value)
        {
            parentNode.Left = null;
        }
        else
        {
            parentNode.Right = null;
        }
    }

    private void DeleteNodeWithOneChild(AVLNode nodeToDelete, AVLNode parentNode)
    {
        var childNode = nodeToDelete.Left ?? nodeToDelete.Right;

        if (parentNode == null)
        {
            Root = childNode;
            return;
        }

        if (parentNode.Left?.Value == nodeToDelete.Value)
        {
            parentNode.Left = childNode;
        }
        else
        {
            parentNode.Right = childNode;
        }
    }

    private void DeleteNodeWithTwoChildren(AVLNode nodeToDelete)
    {
        var nodeToReplaceWith = FindMinInternal(nodeToDelete.Right);

        Remove(nodeToReplaceWith.Value);

        nodeToDelete.Value = nodeToReplaceWith.Value;
    }

    private AVLNode FindMinInternal(AVLNode currentNode)
    {
        if (currentNode == null)
            return null;

        while (currentNode.Left != null)
        {
            currentNode = currentNode.Left;
        }

        return currentNode;
    }

    private AVLNode BalanceTree(AVLNode node)
    {
        if (node.BalanceFactor < 0)
        {
            if (node.Right.BalanceFactor < 0)
            {
                return RotationRR(node);
            }

            if (node.Right.BalanceFactor > 0)
            {
                var pivotnode = node.Right;
                node.Right = RotationLL(pivotnode);
                return RotationRR(node);
            }
        }

        if (node.BalanceFactor > 0)
        {
            if (node.Left.BalanceFactor > 0)
            {
                return RotationLL(node);
            }

            if (node.Left.BalanceFactor < 0)
            {
                var pivotnode = node.Left;
                node.Left = RotationRR(pivotnode);
                return RotationLL(node);
            }
        }

        return node;
    }

    private AVLNode RotationRR(AVLNode currentNode)
    {
        var pivotNode = currentNode.Right;
        currentNode.Right = pivotNode.Left;
        pivotNode.Left = currentNode;

        return pivotNode;
    }
    
    private AVLNode RotationLL(AVLNode currentNode)
    {
        var pivotNode = currentNode.Left;
        currentNode.Left = pivotNode.Right;
        pivotNode.Right = currentNode;

        return pivotNode;
    }

    private void CheckTreeBalance()
    {
        if (Root == null)
            return;

        Root = TraverseNode(Root);
        
        
    }

    private AVLNode TraverseNode(AVLNode node)
    {
        if (node.Left != null)
           node.Left = TraverseNode(node.Left);

        if (node.Right != null)
          node.Right = TraverseNode(node.Right);

        node = ValidateBalance(node);

        CalculateNodeHeight(node);

        return node;
    }

    private AVLNode ValidateBalance(AVLNode node)
    {
        node.BalanceFactor = (node.Left?.Height ?? 0) - (node.Right?.Height ?? 0);

        if (node.BalanceFactor is < -1 or > 1)
        {
            var newNode = BalanceTree(node);
            
            TraverseNode(newNode);

            newNode.BalanceFactor = (newNode.Left?.Height ?? 0) - (newNode.Right?.Height ?? 0);
            return newNode;
        }

        return node;
    }

    private void CalculateNodeHeight(AVLNode node)
    {
        var currenHeight = 1;

        if (node.Left != null)
        {
            currenHeight = node.Left.Height + 1;
        }

        if (node.Right != null)
        {
            var heightRightSide = node.Right.Height + 1;

            if (heightRightSide > currenHeight)
                currenHeight = heightRightSide;
        }

        node.Height = currenHeight;
    }
}