// See https://aka.ms/new-console-template for more information

int[] nums = { -1, 0, 1, 2, -1, -4 };

ThreeSum(nums);
/// <summary>
/// Create a new List of Lists; if length of nums is 0 or 1 return empty list; 
/// sort the input array; do a for loop for nums; if i > 0 and nums[i] == nums[i - 1] continue; 
/// assign two pointers such that l = i + 1,r = nums.Length - 1; 
/// do a while loop such that while(l < r); (Since we don't want duplicates); 
/// calculate three sum such that threeSum = nums[i] + nums[l] + nums[r]; 
/// if threeSum > 0 , r-- else if(threeSum < 0), l++; 
/// else add all the three to the list and increment left pointer; 
/// imp condition -> while(nums[l] == nums[l - 1] && l < r, do l++; 
/// after coming out of the loop, return result. 
/// Time Complexity -> O(n2) and Space Complexity -> O(n)
/// </summary>
IList<IList<int>> ThreeSum(int[] nums)
{
    IList<IList<int>> result = new List<IList<int>>();
    if(nums.Length == 0 || nums.Length == 1)
    {
        return result;
    }

    Array.Sort(nums);

    for(int i = 0; i < nums.Length; i++)
    {
        if(i > 0 && nums[i] == nums[i - 1])
        {
            continue;
        }

        int l = i + 1;
        int r = nums.Length - 1;

        while(l < r)
        {
            int threeSum = nums[i] + nums[l] + nums[r];
            if(threeSum > 0)
            {
                r--;
            }
            else if(threeSum < 0)
            {
                l++;
            }
            else
            {
                result.Add(new List<int> { nums[i], nums[l], nums[r]});
                l++;
                while(nums[l] == nums[l - 1] && l < r)
                {
                    l++;
                }
            }
        }
    }

    return result;
}