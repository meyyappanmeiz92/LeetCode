// See https://aka.ms/new-console-template for more information
/// <summary>
/// base case : if length of array is one, return that element (nums[0])
/// initialise hashet of integers
/// do a for loop on all the elements of the array
/// if hashset contains that element, remove that element and continue to next iteration
/// if not, add that element to hashset
/// after coming out of the loop, return set.first()
/// </summary>
int[] nums = new int[] { 4, 1, 2, 1, 2 };
SingleNumber(nums);
int SingleNumber(int[] nums)
{
   if(nums.Length == 1)
   {
       return nums[0];
   }

   HashSet<int> set = new HashSet<int>();
   for(int i = 0; i < nums.Length; i++)
   {
        if (set.Contains(nums[i]))
        {
            set.Remove(nums[i]);
            continue;
        }

        set.Add(nums[i]);
   }

    return set.First();
}
