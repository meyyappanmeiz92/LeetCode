/// <summary>
/// Two pointer solution
/// Assign index to 0 and loop through each element
/// if target != array[i], assign that value to array[index] and then increment the index
/// After looping through all the elements, return the index value
/// </summary>

int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
RemoveElement(nums, 2);

int RemoveElement(int[] nums, int value)
{
    int index = 0;
    for(int i = 0; i < nums.Length; i++)
    {
        if(nums[i] != value)
        {
            nums[index] = nums[i];
            index++;
        }
    }

    return index;
}