using System;
using System.Collections.Generic;

public class Program
{

    // Two sum solution
    // In a more efficient way in terms of of time complexity as previous solution was
    // done through nested loop which isnt ideal. 
    public static void Main()
    {
        Solution solution = new Solution();
        // Define your array of numbers
        int[] nums = { 2, 7, 11, 15 };
        // Define the target sum
        int target = 13;

        // Call the TwoSum method to find indices of the two numbers that add up to the target
        int[] result = solution.TwoSum(nums, target);
        // Output the result
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Create a dictionary to store numbers and their indices
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // Calculate the x of the current number to reach the target
            int x = target - nums[i];

            // Check if the x is already in the map
            if (numMap.ContainsKey(x))
            {
                // If x is found, return the pair of indices
                return new int[] { numMap[x], i };
            }

            // If the current number is not in the map, add it
            if (!numMap.ContainsKey(nums[i]))
            {
                numMap.Add(nums[i], i);
            }
        }

        // If no solution is found, throw an exception
        throw new ArgumentException("No two sum solution found");
    }
}
