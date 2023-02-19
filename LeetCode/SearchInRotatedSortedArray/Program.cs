// See https://aka.ms/new-console-template for more information
int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
int target = 0;

Search(nums, target);

/// <summary>
/// Binary Search -> 
/// Assign two pointers left to index 0 and right to n-1, 
/// do a while loop while(left <= right), and assign a mid pointer such that mid = (left+right)/2, 
/// if(target == nums[mid]) return mid if not, 
/// then check if mid pointer is >= left pointer, 
/// if it is we are in the left sorted array and check if target is less that left pointer or mid pointer is greater than target, 
/// if it is then do left = mid + 1 else right = mid - 1. 
/// if mid pointer is less than left pointer, 
/// then we are in right sorted array, check if target is greater than right pointer or mid pointer is less than target, 
/// right = mid - 1 else left = mid + 1, 
/// if non of the conditions match, return -1
/// Time Complexity -> O(log n) and Space Complexity ->O(1)
/// </summary>
int Search(int[] nums, int target)
{
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;

        if (target == nums[mid])
        {
            return mid;
        }

        if (nums[mid] >= nums[left])
        {
            if ((target < nums[left]) || (target > nums[mid]))
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        else
        {
            if ((target > nums[right]) || (target < nums[mid]))
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
    }

    return -1;
}
