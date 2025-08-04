using System;
using System.Collections.Generic;

/// <summary>
/// This file contains examples from the Week 05 preparation material
/// demonstrating various recursive algorithms and concepts.
/// </summary>
public static class RecursionExamples
{
    /// <summary>
    /// Activity instruction from the preparation material:
    /// Consider using a recursive function to sum all of the numbers from 1 to n.
    /// 
    /// Smaller version: Sum from 1 to (n-1) and add n
    /// Base case: When n <= 0, return 0
    /// </summary>
    public static int SumNumbers(int n)
    {
        // Base case: if n <= 0, return 0
        if (n <= 0)
            return 0;
        
        // Recursive case: n + sum of numbers from 1 to (n-1)
        return n + SumNumbers(n - 1);
    }

    /// <summary>
    /// Example from preparation material: Calculate factorial using recursion
    /// </summary>
    public static int Factorial(int n)
    {
        if (n <= 1)
        {
            // 1! = 1 (no recursion)
            return 1;
        }
        else
        {
            // n! = n * (n - 1)!
            return n * Factorial(n - 1);
        }
    }

    /// <summary>
    /// Example from preparation material: Fibonacci with memoization
    /// </summary>
    public static long Fibonacci(int n, Dictionary<int, long>? remember = null)
    {
        // If this is the first time calling the function, then
        // we need to create the dictionary.
        if (remember == null)
            remember = new Dictionary<int, long>();

        // Base Case
        if (n <= 2)
            return 1;

        // Check if we have solved this one before
        if (remember.ContainsKey(n))
            return remember[n];

        // Otherwise solve with recursion
        var result = Fibonacci(n - 1, remember) + Fibonacci(n - 2, remember);

        // Remember result for potential later use
        remember[n] = result;
        return result;
    }

    /// <summary>
    /// Example from preparation material: Find all permutations of a string
    /// </summary>
    public static void Permutations(string letters, string word = "")
    {
        // Try adding each of the available letters
        // to the 'word' and add up all the
        // resulting permutations.
        if (letters.Length == 0)
        {
            Console.WriteLine(word);
        }
        else
        {
            for (var i = 0; i < letters.Length; i++)
            {
                // Make a copy of the letters to pass to the
                // the next call to permutations.  We need
                // to remove the letter we just added before
                // we call permutations again.
                var lettersLeft = letters.Remove(i, 1);

                // Add the new letter to the word we have so far
                Permutations(lettersLeft, word + letters[i]);
            }
        }
    }

    /// <summary>
    /// Example from preparation material: Binary search using recursion
    /// </summary>
    public static bool BinarySearch(int[] sortedArray, int target)
    {
        if (sortedArray.Length == 1)
        {
            // Base case
            return target == sortedArray[0];
        }
        else
        {
            // Find the middle and compare
            var middle = sortedArray.Length / 2;

            if (target == sortedArray[middle])
            {
                // We got lucky and the middle was the match
                return true;
            }
            else if (target < sortedArray[middle])
            {
                // Search the first half (index 0 to middle-1) and return the result
                return BinarySearch(sortedArray[..middle], target);
            }
            else
            {
                // Search the second half (index middle to end) and return the result
                return BinarySearch(sortedArray[middle..], target);
            }
        }
    }

    /// <summary>
    /// Demonstration method to show all the examples in action
    /// </summary>
    public static void RunExamples()
    {
        Console.WriteLine("=== Week 05 Recursion Examples ===\n");

        // 1. Sum Numbers (Activity instruction)
        Console.WriteLine("1. Sum of numbers from 1 to 5:");
        Console.WriteLine($"   Result: {SumNumbers(5)}"); // Should be 15 (1+2+3+4+5)
        Console.WriteLine();

        // 2. Factorial
        Console.WriteLine("2. Factorial examples:");
        Console.WriteLine($"   5! = {Factorial(5)}"); // Should be 120
        Console.WriteLine($"   3! = {Factorial(3)}"); // Should be 6
        Console.WriteLine();

        // 3. Fibonacci
        Console.WriteLine("3. Fibonacci examples:");
        Console.WriteLine($"   Fib(1) = {Fibonacci(1)}");   // 1
        Console.WriteLine($"   Fib(2) = {Fibonacci(2)}");   // 1
        Console.WriteLine($"   Fib(3) = {Fibonacci(3)}");   // 2
        Console.WriteLine($"   Fib(4) = {Fibonacci(4)}");   // 3
        Console.WriteLine($"   Fib(10) = {Fibonacci(10)}"); // 55
        Console.WriteLine($"   Fib(40) = {Fibonacci(40)}"); // Works fast with memoization
        Console.WriteLine();

        // 4. Permutations
        Console.WriteLine("4. Permutations of 'ABC':");
        Permutations("ABC");
        Console.WriteLine();

        // 5. Binary Search
        Console.WriteLine("5. Binary Search examples:");
        int[] sortedArray = {1, 3, 6, 18, 20, 25, 34, 38, 89, 95, 99, 100};
        Console.WriteLine($"   Search for 89: {BinarySearch(sortedArray, 89)}"); // true
        Console.WriteLine($"   Search for 1: {BinarySearch(sortedArray, 1)}");   // true
        Console.WriteLine($"   Search for 17: {BinarySearch(sortedArray, 17)}"); // false
    }
}
