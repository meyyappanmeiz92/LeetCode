// See https://aka.ms/new-console-template for more information
/// <summary>
/// Create a dictionary and add array element as a key and occurence as a count
/// if it contains a key, then increase the count by one
/// else add the element to dictionary and initialise the count as 1
/// after coming out of the loop, return the element which appears more than n / 2 times in dictionary
/// </summary>
//int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
//MajorityElement(nums);

//int MajorityElement(int[] nums) 
//{ 
//    Dictionary<int, int> result = new Dictionary<int, int>();
//    int count = 1;
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (result.ContainsKey(nums[i]))
//        {
//            result[nums[i]]++;
//        }
//        else
//        {
//            result.Add(nums[i], count);
//        }
//    }
//    var res = result.Where(x => x.Value > nums.Length / 2).Select(x => x.Key).First();
//    return res;
//}

///Boyer Moore Algorithm
///Two variables count and ansIndex(any name)
///Initialise count to 1 and ansIndex to 0
///loop through all elements until the nums length
///if nums[i] == nums[ansIndex], increment count
///else decrement count
///if count is 0, reset ansIndex to i and count to 1
///after for loop exits, return nums[ansIndex]

int[] nums = new int[] { 2,3,2,3,2 };
MajorityElement(nums);

int MajorityElement(int[] nums)
{
    int count = 1;
    int ansIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == nums[ansIndex])
        {
            count++;
        }
        else
        {
            count--;
        }

        if (count == 0)
        {
            ansIndex = i;
            count = 1;
        }
    }

    return nums[ansIndex];
}