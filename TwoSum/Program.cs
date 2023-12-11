using System;
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        // Change these to test different inputs
        int[] nums = { 2, 7, 11, 15 };
        // change this to test a different target
        int target = 13;

        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"Indices: {result[0]}, {result[1]}");
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // Iterate through each element in the array
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                // Check if the sum of the current pair equals the target
                if (nums[i] + nums[j] == target)
                {
                    // Return the indices of the two numbers
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution found");
    }
}