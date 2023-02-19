// See https://aka.ms/new-console-template for more information
/// <summary>
/// initialize dictionary
/// initialize an array with 2 space elements
/// initilize temp variable
/// do a for loop for given array
/// if it contains the key temp = target - nums[i] then
/// do trygetvalue on the dictionary for temp variable and assign it to arr[0]
/// and assign arr[1] = i
/// return the array
/// if not add the value result.Add(nums[i], i) to dictionary
/// when we come out of loop, return the array.
/// </summary>
int[] nums = new int[4]{ 2, 7, 11, 15 };
int target = 9;
TwoSum(nums, target);

//int[] TwoSum(int[] nums, int target)
//{
//    int[] num = new int[2];
//    for (int i = 0; i < nums.Length; i++)
//    {
//        for (int j = i + 1; j < nums.Length; j++)
//        {
//            if (nums[i] + nums[j] == target)
//            {
//                num[0] = i;
//                num[1] = j;
//            }
//        }
//    }

//    return num;
//}

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> dictionary = new Dictionary<int, int>();
    int[] arr = new int[2];
    int temp;

    for (int i = 0; i < nums.Length; i++)
    {
        if (dictionary.ContainsKey(temp = target - nums[i]))
        {
            dictionary.TryGetValue(temp, out arr[0]);
            arr[1] = i;

            return arr;
        }

        dictionary.Add(nums[i], i);
    }

    return arr;
}




