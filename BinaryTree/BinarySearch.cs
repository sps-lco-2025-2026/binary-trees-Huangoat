namespace BinaryTree;

public class Tree
{
    Node? root;

    public void Add(int v)
    {
        if (root == null)
        {
           root = new Node(v);
        }
        else
        {
            root.Compare(v);
        }

    }
    public int Sum()
    {
        if (root != null)
        {
            return root.Sum();
        }
        return -1;
    }
    public override string ToString()
    {

        return Traverse();
    }

    public string Traverse()
    {
        if (root != null)
        {
            return root.Traverse();
        }
        return "";
    }

    public bool IsDuplicates()
    {
        if (root != null)
        {
            return root.IsDuplicates(new List<int>());
        }
        return false;
    }

}
internal class Node
{
    public int _value;
    Node? left;
    Node? right;

    internal Node(int v)
    {
        _value = v;
        left = null;
        right = null;
    }
    public void Compare(int v)
    {
        if (v < _value)
        {
            if (left == null) left = new Node(v);
            else left.Compare(v);
        }
        else
        {
            if (right == null) right = new Node(v);
            else right.Compare(v);
        }
    }

    public int Sum()
    {
        if (left == null && right == null)
        {
            return _value;
        }
        int total = _value;
        if (left != null) total += left.Sum();
        if (right != null) total += right.Sum();
        return total;
        
    }
    public string Traverse()
    {
        string s = "";
        if (left != null) s += left.Traverse();
        s += _value + " ";
        if (right != null) s += right.Traverse();
        return s;
    }
    public bool IsDuplicates(List<int> list)
    {
        if (list.Contains(_value))
        {
            return true;
        }
        else
        {
            list.Add(_value);
        }
        bool leftDup = false;
        bool rightDup = false;
        if (left != null) leftDup = left.IsDuplicates(list);
        if (right != null) rightDup = right.IsDuplicates(list);;
        return leftDup || rightDup;

    }

}



