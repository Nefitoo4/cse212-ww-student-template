using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchTree : IEnumerable<int>
{
    // Node root of the tree
    private Node? _root;
    
    // Moved here to check if the tree contains a value
        public bool Contains(int value)
    {
        return _root != null && _root.Contains(value);
    }
    public void Insert(int value)
    {
        // Create new node
        // Node newNode = new(value); // not necessary for insertion in the tree
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
        {
            _root = new Node(value);
        }
        // If the list is not empty, then only head will be affected.
        else
        {
            _root.Insert(value); // calls the Insert method of the Node class
        }
    }

    /// <summary>
    /// Insert a new node in the BST.
    /// Internal class representing a node in the tree
    public class Node
    {
        public int Data;
        public Node? Left;
        public Node? Right;
        public Node(int data)
        {
            Data = data;
        }
        /// </summary>
        /// Looks recursively for a value in the tree
        public bool Contains(int value)
        {
            if (value == Data)
                return true;
            else if (value < Data)
                return Left != null && Left.Contains(value);
            else // if value > Data
                return Right != null && Right.Contains(value);
        }

        // Calculates recursively the height of the subtree
        public int GetHeight()
        {
            int leftHeight = Left != null ? Left.GetHeight() : 0;
            int rightHeight = Right != null ? Right.GetHeight() : 0;
            return 1 + Math.Max(leftHeight, rightHeight);
        }
        // Inserts a value in the subtree
        public void Insert(int value)
        {
            if (value == Data)
            {
                // if value already exists, do not insert it again
                return;
            }
            else if (value < Data)
            {
                if (Left == null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else // if value > Data
            {
                if (Right == null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }

        /// <summary>
        /// Check to see if the tree contains a certain value
        /// </summary>
        /// <param name="value">The value to look for</param>
        /// <returns>true if found, otherwise false</returns>

        /// <summary>
        /// Yields all values in the tree
        /// </summary>
    }
        /// Allows traverse the tree in ascending order using foreach
    public IEnumerator<int> GetEnumerator()
    {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    private void TraverseForward(Node? node, List<int> values)
    {
        if (node is not null)
        {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the BST.
    /// </summary>
    public IEnumerable Reverse()
    {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers)
        {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values)
    {
        // TODO Problem 3
        // verification if node is not null
        if (node is not null)
        {
            // first, traverse the right subtree
            TraverseBackward(node.Right, values);
            // then, add the current node's value
            values.Add(node.Data);
            // finally, traverse the left subtree
            TraverseBackward(node.Left, values);
        }
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight()
    {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString()
    {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
}

public static class IntArrayExtensionMethods
{
    public static string AsString(this IEnumerable array)
    {
        return "<IEnumerable>{" + string.Join(", ", array.Cast<int>()) + "}";
    }
}