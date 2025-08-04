using System;

/// <summary>
/// Demonstration class for the recursion examples from Week 05 preparation material
/// This can be called from tests or other methods to show the examples
/// </summary>
public static class RecursionDemo
{
    public static void RunAllExamples()
    {
        try
        {
            RecursionExamples.RunExamples();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        
        Console.WriteLine("\n=== Testing Your Implemented Solutions ===");
        
        // Test the solutions you've already implemented
        Console.WriteLine("\n1. Sum of Squares (your implementation):");
        Console.WriteLine($"   Sum of squares 1² + 2² + ... + 5² = {Recursion.SumSquaresRecursive(5)}"); // Should be 55
        
        Console.WriteLine("\n2. Permutations Choose (your implementation):");
        var results = new List<string>();
        Recursion.PermutationsChoose(results, "ABC", 2);
        Console.WriteLine($"   Permutations of size 2 from 'ABC': {string.Join(", ", results)}");
        
        Console.WriteLine("\n3. Count Ways to Climb (your implementation):");
        Console.WriteLine($"   Ways to climb 5 stairs: {Recursion.CountWaysToClimb(5)}");
        
        Console.WriteLine("\n4. Wildcard Binary (your implementation):");
        var binaryResults = new List<string>();
        Recursion.WildcardBinary("1*1", binaryResults);
        Console.WriteLine($"   Binary patterns for '1*1': {string.Join(", ", binaryResults)}");
    }
}
