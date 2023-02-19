// See https://aka.ms/new-console-template for more information
/// <summary>
/// Base case: if length of array is 0, return 0
/// initialise HashSet of integers
/// loop through all elements in the array and add it to hashset (come out of the loop)
/// if count inside set is 1 or 2, return set.Max()
/// if not, loop through 2 iterations and remove the max value in set
/// after coming out of the loop, return set.Max().
/// </summary>
int[] nums = { 1, 2, 3 };

ThirdMax(nums);
int ThirdMax(int[] nums)
{
    if (nums.Length == 0)
    {
        return 0;
    }
    HashSet<int> set = new HashSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        set.Add(nums[i]);
    }

    if (set.Count == 2 || set.Count == 1)
    {
        var s = set.Max();
        return s;
    }
    for (int i = 0; i < 2; i++)
    {
        int res = set.Max();
        set.Remove(res);
    }

    return set.Max();
}
