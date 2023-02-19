// See https://aka.ms/new-console-template for more information
/// <summary>
/// find the max in the array and assign it to result variable
/// To track max and min, we can have a varaible and assign it to 1 initially
/// do a for loop, if any element is 0, then reset max and min to 1 and jump to next one
/// else, assign a temp variable to curMax * nums[i] (just that we don't mutate the curMax value for curMin in the same iteration
/// calculate curMax => Math.Max(Math.Max(curMax * nums[i], curMin * nums[i]), Math.Max(curMax * nums[i], nums[i]))
/// calculate  curMin => Math.Min(Math.Min(curMin * nums[i], temp), Math.Min(curMin * nums[i], nums[i]))
/// calculate res = Math.Max(res, curMax)
/// </summary>


int[] nums = { -2,0,-1};
MaxProduct(nums);

int MaxProduct(int[] nums)
{
    int res = nums.Max();
    int curMax = 1;
    int curMin = 1;

    for(int i = 0; i < nums.Length; i++)
    {
        if(nums[i] == 0)
        {
            curMax = 1;
            curMin = 1;
            continue;
        }

        int temp = curMax * nums[i];
        curMax = Math.Max(Math.Max(curMax * nums[i], curMin * nums[i]), Math.Max(curMax * nums[i], nums[i]));
        curMin = Math.Min(Math.Min(temp, curMin * nums[i]), Math.Min(curMin * nums[i], nums[i]));
        res = Math.Max(res, curMax);
    }

    return res;
}
