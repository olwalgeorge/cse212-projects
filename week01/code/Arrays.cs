public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step-by-step plan for MultiplesOf function:
        // 1. Create an array of doubles with the specified length
        // 2. Use a for loop to iterate from 0 to length-1
        // 3. For each position i, calculate the multiple: number * (i + 1)
        //    - We use (i + 1) because we want the 1st, 2nd, 3rd, etc. multiples
        //    - For example: if number = 7, we want 7*1, 7*2, 7*3, etc.
        // 4. Store each calculated multiple in the array at position i
        // 5. Return the completed array

        // Step 1: Create array with specified length
        double[] multiples = new double[length];

        // Step 2-4: Loop through and calculate each multiple
        for (int i = 0; i < length; i++)
        {
            // Step 3: Calculate the multiple (number * multiplier)
            // The multiplier is (i + 1) because we want 1st, 2nd, 3rd multiple, etc.
            multiples[i] = number * (i + 1);
        }

        // Step 5: Return the completed array
        return multiples;
        // TODO Problem 1 End
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step-by-step plan for RotateListRight function:
        // 1. Check if the list is empty or amount is 0 - if so, do nothing
        // 2. Normalize the amount using modulo to handle cases where amount > data.Count
        // 3. Calculate the split point: where to split the list
        //    - For right rotation by 'amount', we need to take the last 'amount' elements
        //    - Split point = data.Count - amount
        // 4. Use GetRange to extract two parts:
        //    - Part 1: Elements from split point to end (these go to the front)
        //    - Part 2: Elements from start to split point (these go to the back)
        // 5. Clear the original list
        // 6. Add Part 1 first, then Part 2

        // Step 1: Handle edge cases
        if (data.Count == 0 || amount == 0)
            return;

        // Step 2: Normalize amount to handle cases where amount > data.Count
        amount = amount % data.Count;
        if (amount == 0) // After normalization, if amount is 0, no rotation needed
            return;

        // Step 3: Calculate split point
        // For right rotation, we move the last 'amount' elements to the front
        int splitPoint = data.Count - amount;

        // Step 4: Extract the two parts
        // Part 1: Last 'amount' elements (from splitPoint to end)
        List<int> part1 = data.GetRange(splitPoint, amount);
        // Part 2: First elements (from 0 to splitPoint)
        List<int> part2 = data.GetRange(0, splitPoint);

        // Step 5: Clear the original list
        data.Clear();

        // Step 6: Add part1 first (the elements that were at the end)
        data.AddRange(part1);
        // Then add part2 (the elements that were at the beginning)
        data.AddRange(part2);
        // TODO Problem 2 End
    }
}
