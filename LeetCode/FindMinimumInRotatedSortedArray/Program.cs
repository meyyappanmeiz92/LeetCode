// See https://aka.ms/new-console-template for more information
/// <summary>
/// Binary Search Algo (not traditional one since this is rotated sorted array)
/// Declare res variable to store result, and assign it to nums[0],  
/// Assign two pointers, left pointer to index 0 and right to n-1. 
/// Do a while loop while(left <= right), if(nums[left] < nums[right], Calculate Math.Min(res, nums[left]), 
/// break out of while loop, 
/// if it is not, then calcule middle such that mid = (left +right)/2 , then reset res = Math.Min(res, nums[mid]), 
/// then do if(nums[mid] >= nums[left]), if this is true then we have to search right (i.e) left = mid + 1 
/// else we have to search left (i.e) right = mid - 1, then return res
/// Time Complexity -> O(log n) and Space Complexity ->O(1)
/// </summary>
int[] nums = {7,8,9,10,1,2,3}; // 1 2 3 4 5   5,1,2,3,4   4,5,1,2,3   3,4,5,1,2
FindMin(nums);

int FindMin(int[] nums)
{
    int res = nums[0];
    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
        if (nums[left] < nums[right])
        {
            res = Math.Min(res, nums[left]);
            break;
        }

        int middle = (left + right) / 2;
        res = Math.Min(res, nums[middle]);
        if (nums[middle] >= nums[left])
        {
            left = middle + 1;
        }
        else
        {
            right = middle - 1;
        }
    }

    return res;
}

