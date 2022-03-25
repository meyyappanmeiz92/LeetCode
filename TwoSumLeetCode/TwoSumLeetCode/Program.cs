// See https://aka.ms/new-console-template for more information
int[] nums = new int[4]{ 2, 7, 11, 15 };
int target = 9;
TwoSum(nums, target);

int[] TwoSum(int[] nums, int target)
{
    int[] num = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                num[0] = i;
                num[1] = j;
            }
        }
    }

    return num;
}
