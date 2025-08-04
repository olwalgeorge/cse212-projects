public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (no duplicates allowed)
    }

    public bool Contains(int value)
    {
        // Base case: found the value
        if (value == Data)
            return true;
        
        // Recursive case: search in appropriate subtree
        if (value < Data)
        {
            // Search in left subtree
            return Left != null && Left.Contains(value);
        }
        else
        {
            // Search in right subtree
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Base case: if this is a leaf node, height is 1
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        
        // Return 1 (for current node) + maximum height of subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}