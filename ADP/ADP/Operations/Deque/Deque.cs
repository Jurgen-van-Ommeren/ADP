namespace ADP.Operations.Deque;

public class Deque<T>
{
    private DequeNode<T> _firstNode;
    private DequeNode<T> _lastNode;
    
    private int _size;
    
    public void InsertLeft(T value)
    {
        var newNode = new DequeNode<T>(value);

        if (_firstNode == null)
        {
            _firstNode = newNode;
            _lastNode = newNode;
        }
        else
        {
            newNode.Next = _firstNode;

            _firstNode.Prev = newNode;
            _firstNode = newNode;
        }

        _size++;
    }
    
    public void InsertRight(T value)
    {
        var newNode = new DequeNode<T>(value);

        if (_firstNode == null)
        {
            _firstNode = newNode;
            _lastNode = newNode;
        }
        else
        {
            newNode.Prev = _lastNode;

            _lastNode.Next = newNode;
            _lastNode = newNode;
        }

        _size++;
    }
    
    public void DeleteLeft()
    {
        if (_firstNode == null)
        {
            return;
        }
        
        var newFirstNode = _firstNode.Next;
        
        if (newFirstNode == null)
        {
            _firstNode = null;
            _lastNode = null;            
        }
        else
        {
            newFirstNode.Prev = null;
            _firstNode = newFirstNode;    
        }

        _size--;
    }
    
    public void DeleteRight()
    {
        if (_lastNode == null)
        {
            return;
        }
        
        var newLastNode = _lastNode.Prev;
        
        if (newLastNode == null)
        {
            _firstNode = null;
            _lastNode = null;
        }
        else
        {
            newLastNode.Next = null;
            _lastNode = newLastNode;    
        }
        
        _size--;
    }

    public int Size()
    {
        return _size;
    }
}