// See https://aka.ms/new-console-template for more information
/// <summary>
/// If length is 0, return false
/// Create HashSet and compare each element in the array,
/// if it contains the element in HashSet, return true
/// else add it to the HashSet
/// after looping through all the elements in the array, if we don't find any duplicate,
/// return false
/// </summary>
int[] nums = { 1, 3, 3, 4, 3, 2, 4, 2 };
ContainsDuplicate(nums);

bool ContainsDuplicate(int[] nums)
{
   
    if(nums.Length == 0)
    {
        return false;
    }

    HashSet<int> set = new HashSet<int>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (set.Contains(nums[i]))
        {
            return true;
        }

        set.Add(nums[i]);
    }

    return false;
}

//2nd approach
/// Two for loops and compare 1st element of i with every element in j
/// if duplicate found, return true 
/// else false
/// Brute force - Slower

//int[] nums = { 1, 2, 3, 4, 1 };
//ContainsDuplicate(nums);

//bool ContainsDuplicate(int[] nums)
//{
//    if (nums.Length == 0)
//    {
//        return false;
//    }

//    for(int i = 0; i < nums.Length; i++)
//    {
//        for(int j = i + 1; j < nums.Length; j++)
//        {
//            if(nums[i] == nums[j])
//            {
//                return true;
//            }
//        }
//    }

//    return false;
//}

/// 3rd approach
/// sort the array and compare one element with next element in for loop
/// if duplicate found, return true
/// else return false

//int[] nums = { 1, 2, 3, 4, 1 };
//ContainsDuplicate(nums);

//bool ContainsDuplicate(int[] nums)
//{
//    if (nums.Length == 0)
//    {
//        return false;
//    }

//   Array.Sort(nums);
//   for(int i = 0; i < nums.Length - 1; i++)
//    {
//        if (nums[i] == nums[i + 1])
//        {
//            return true;
//        }
//    }

//   return false;
//}





