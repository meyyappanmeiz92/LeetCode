// See https://aka.ms/new-console-template for more information

using System.Linq;

int[] nums = {2, 1, 3, 1};
int k = 3;

/// <summary>
/// initilaise dictionary of int
/// Push value as key and index as value to dictionary
/// check for value and assign it to j and Math.Abs(i - j) <= k
/// if it is, then return true else add it to dictionary
/// if none of the case match, return false
/// </summary>
ContainsNearbyDuplicate(nums, k);

bool ContainsNearbyDuplicate(int[] nums, int k)
{
    var seen = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        var current = nums[i];
        if (seen.TryGetValue(current, out var j) && (i - j) <= k)
        {
            return true;
        }

        seen[current] = i;
    }

    return false;
}
