using System;

/// <summary>
/// Demonstration program for Week 06 Tree examples
/// This can be called from tests or other methods to show the examples
/// </summary>
public static class TreeDemo
{
    public static void RunAllTreeExamples()
    {
        try
        {
            TreeExamples.RunAllExamples();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        Console.WriteLine("\n=== Testing Your BST Implementation ===");
        
        // Test basic operations
        Console.WriteLine("\n1. Basic BST Operations:");
        var testBst = new BinarySearchTree();
        testBst.Insert(5);
        testBst.Insert(3);
        testBst.Insert(7);
        testBst.Insert(1);
        testBst.Insert(9);
        
        Console.WriteLine($"   BST: {testBst}");
        Console.WriteLine($"   Contains 7: {testBst.Contains(7)}");
        Console.WriteLine($"   Contains 4: {testBst.Contains(4)}");
        Console.WriteLine($"   Height: {testBst.GetHeight()}");
        Console.WriteLine($"   Reverse: {string.Join(", ", testBst.Reverse().AsString())}");
        
        // Test balanced tree creation
        Console.WriteLine("\n2. Balanced Tree Creation:");
        var sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var balancedTree = Trees.CreateTreeFromSortedList(sortedArray);
        Console.WriteLine($"   Sorted array: [{string.Join(", ", sortedArray)}]");
        Console.WriteLine($"   Balanced BST: {balancedTree}");
        Console.WriteLine($"   Height: {balancedTree.GetHeight()} (optimal for {sortedArray.Length} nodes)");
    }
}
