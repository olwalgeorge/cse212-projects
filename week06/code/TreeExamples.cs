using System;
using System.Collections.Generic;

/// <summary>
/// This file contains examples from the Week 06 preparation material
/// demonstrating various tree and binary search tree concepts.
/// </summary>
public static class TreeExamples
{
    /// <summary>
    /// Demonstrates basic BST operations as shown in the preparation material
    /// </summary>
    public static void DemonstrateBSTOperations()
    {
        Console.WriteLine("=== Binary Search Tree Operations ===\n");

        // Create a BST and insert values as shown in preparation material
        var bst = new BinarySearchTree();
        
        Console.WriteLine("1. Inserting values: 15, 10, 24, 3, 14, 33");
        bst.Insert(15);  // Root
        bst.Insert(10);  // Left of 15
        bst.Insert(24);  // Right of 15
        bst.Insert(3);   // Left of 10
        bst.Insert(14);  // Right of 10
        bst.Insert(33);  // Right of 24
        
        Console.WriteLine($"   BST: {bst}");
        Console.WriteLine();

        // Demonstrate adding the value 20 as shown in preparation material
        Console.WriteLine("2. Adding value 20:");
        Console.WriteLine("   - Start at root 15, compare with 20");
        Console.WriteLine("   - 20 > 15, go right to 24");
        Console.WriteLine("   - 20 < 24, go left and find empty spot");
        bst.Insert(20);
        Console.WriteLine($"   BST after adding 20: {bst}");
        Console.WriteLine();

        // Demonstrate Contains operation
        Console.WriteLine("3. Testing Contains operation:");
        Console.WriteLine($"   Contains 20: {bst.Contains(20)}");
        Console.WriteLine($"   Contains 15: {bst.Contains(15)}");
        Console.WriteLine($"   Contains 25: {bst.Contains(25)}");
        Console.WriteLine();

        // Demonstrate traversal
        Console.WriteLine("4. Tree Traversals:");
        Console.WriteLine($"   Forward (In-order):  {bst}");
        Console.WriteLine($"   Reverse (Reverse):   {string.Join(", ", bst.Reverse().AsString())}");
        Console.WriteLine();

        // Demonstrate height
        Console.WriteLine($"5. Tree Height: {bst.GetHeight()}");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates the difference between balanced and unbalanced trees
    /// </summary>
    public static void DemonstrateBalancedVsUnbalanced()
    {
        Console.WriteLine("=== Balanced vs Unbalanced Trees ===\n");

        // Create balanced BST
        Console.WriteLine("1. Balanced BST (values inserted as: 15, 10, 24, 3, 14, 33):");
        var balancedBst = new BinarySearchTree();
        balancedBst.Insert(15);
        balancedBst.Insert(10);
        balancedBst.Insert(24);
        balancedBst.Insert(3);
        balancedBst.Insert(14);
        balancedBst.Insert(33);
        Console.WriteLine($"   BST: {balancedBst}");
        Console.WriteLine($"   Height: {balancedBst.GetHeight()} (Good - O(log n) performance)");
        Console.WriteLine();

        // Create unbalanced BST (like a linked list)
        Console.WriteLine("2. Unbalanced BST (values inserted in ascending order: 3, 10, 14, 15, 20, 24, 33):");
        var unbalancedBst = new BinarySearchTree();
        unbalancedBst.Insert(3);
        unbalancedBst.Insert(10);
        unbalancedBst.Insert(14);
        unbalancedBst.Insert(15);
        unbalancedBst.Insert(20);
        unbalancedBst.Insert(24);
        unbalancedBst.Insert(33);
        Console.WriteLine($"   BST: {unbalancedBst}");
        Console.WriteLine($"   Height: {unbalancedBst.GetHeight()} (Poor - O(n) performance, like a linked list)");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates creating a balanced BST from a sorted array
    /// </summary>
    public static void DemonstrateBalancedTreeCreation()
    {
        Console.WriteLine("=== Creating Balanced Tree from Sorted Array ===\n");

        int[] sortedArray = { 10, 20, 30, 40, 50, 60 };
        Console.WriteLine($"Original sorted array: [{string.Join(", ", sortedArray)}]");
        
        // Create balanced BST using the InsertMiddle approach
        var balancedTree = Trees.CreateTreeFromSortedList(sortedArray);
        Console.WriteLine($"Balanced BST: {balancedTree}");
        Console.WriteLine($"Height: {balancedTree.GetHeight()} (Optimal for {sortedArray.Length} nodes)");
        Console.WriteLine();

        Console.WriteLine("How it works:");
        Console.WriteLine("1. Find middle of array (index 2, value 30) -> Insert first");
        Console.WriteLine("2. Recursively insert middle of left half (10, 20) -> Insert 10");
        Console.WriteLine("3. Recursively insert middle of right half (40, 50, 60) -> Insert 50");
        Console.WriteLine("4. Continue until all values inserted");
        Console.WriteLine("5. Insertion order: 30, 10, 50, 20, 40, 60");
        Console.WriteLine();
    }

    /// <summary>
    /// Demonstrates the tree traversal activity from the preparation material
    /// </summary>
    public static void DemonstrateTreeTraversals()
    {
        Console.WriteLine("=== Tree Traversal Activity ===\n");

        // Create the BST from the preparation material activity
        var bst = new BinarySearchTree();
        bst.Insert(15);
        bst.Insert(10);
        bst.Insert(24);
        bst.Insert(3);
        bst.Insert(14);
        bst.Insert(33);

        Console.WriteLine("Tree structure:");
        Console.WriteLine("       15");
        Console.WriteLine("      /  \\");
        Console.WriteLine("    10    24");
        Console.WriteLine("   /  \\     \\");
        Console.WriteLine("  3   14     33");
        Console.WriteLine();

        Console.WriteLine("Traversal Results:");
        Console.WriteLine($"In-order (Left → Node → Right):   {bst}");
        Console.WriteLine("  This gives sorted order for BST!");
        
        Console.WriteLine($"Reverse (Right → Node → Left):    {string.Join(", ", bst.Reverse().AsString())}");
        Console.WriteLine("  This gives reverse sorted order!");
        Console.WriteLine();

        // Manual demonstration of pre-order and post-order
        Console.WriteLine("Other traversal types (for reference):");
        Console.WriteLine("Pre-order (Node → Left → Right):  15, 10, 3, 14, 24, 33");
        Console.WriteLine("Post-order (Left → Right → Node): 3, 14, 10, 33, 24, 15");
        Console.WriteLine();
    }

    /// <summary>
    /// Run all the tree examples
    /// </summary>
    public static void RunAllExamples()
    {
        Console.WriteLine("=== Week 06 Tree Examples ===\n");
        
        DemonstrateBSTOperations();
        DemonstrateBalancedVsUnbalanced();
        DemonstrateBalancedTreeCreation();
        DemonstrateTreeTraversals();
        
        Console.WriteLine("=== Summary ===");
        Console.WriteLine("✓ Binary Search Trees maintain sorted order");
        Console.WriteLine("✓ Balanced trees provide O(log n) performance");
        Console.WriteLine("✓ Unbalanced trees degrade to O(n) performance");
        Console.WriteLine("✓ Creating balanced trees from sorted data requires careful insertion order");
        Console.WriteLine("✓ In-order traversal of BST gives sorted sequence");
    }
}
