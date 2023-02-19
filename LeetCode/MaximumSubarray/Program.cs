// See https://aka.ms/new-console-template for more information
int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
MaxSubArray(nums);
/// <summary>
/// Brute force do two for loops and one more for loop for adding the sums of subarray -> O(n3)
/// Another method, do two for loops and have a variable for max and add to it -> O(n2)
/// Kadane's Algorithm, Two variables one for maxSoFar and one for max and do a for loop
/// Calculate maxSoFar = Math.Max(nums[i], maxSoFar + nums[i])
/// Calculate max = Math.Max(max, maxSoFar)
/// return max
/// </summary>
int MaxSubArray(int[] nums)
{
    int maxSoFar = nums[0];
    int max = nums[0];
    
    for(int i = 1; i < nums.Length; i++)
    {
        maxSoFar = Math.Max(nums[i], maxSoFar + nums[i]);
        max = Math.Max(maxSoFar, max);
    }

    return max;
}