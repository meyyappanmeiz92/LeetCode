// See https://aka.ms/new-console-template for more information
/// <summary>
/// initialise two variables to 0
/// initialise array to length + 1 of actual given array
/// loop through that array and assign the index value to each element of that array
/// then add that element to one of the initialsed variable like res = res + sum[i]
/// do another for loop for given array and add each element to another initialised variable like num = num + nums[j]
/// return res - num
/// </summary>
int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
MissingNumber(nums);

int MissingNumber(int[] nums)
{
    int res = 0;
    int num = 0;
    int[] sum = new int[nums.Length + 1];

    for(int i = 0; i < sum.Length; i++)
    {
        sum[i] = i;
        res = res + sum[i];
    }

    for(int j = 0; j < nums.Length; j++)
    {
        num = num + nums[j];
    }

    return res - num;
}

