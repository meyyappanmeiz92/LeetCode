/// <summary>
/// if given array length is less than or equal to 1, return array length
/// if base case is not true, traverse the array from 1st element to last and
/// initialise another pointer from 0 (lets say index)
/// if ith pointer not equal to index pointer, assign nums[i] to nums[++index]
/// once all the array traversal is done, return index + 1
/// </summary>

int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

RemoveDuplicates(nums);
int RemoveDuplicates(int[] nums)
{
    if(nums.Length <= 1)
    {
        return nums.Length;
    }

    int index = 0;
    for(int i = 1; i < nums.Length; i++)
    {
        if(nums[i] != nums[index])
        {
            nums[++index] = nums[i];
        }
    }

    return index + 1;
}
