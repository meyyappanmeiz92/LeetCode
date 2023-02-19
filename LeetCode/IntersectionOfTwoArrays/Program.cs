// See https://aka.ms/new-console-template for more information
int[] nums1 = { 1, 2, 2, 1 };
int[] nums2 = { 2, 2};

Intersection(nums1, nums2);

/// <summary>
/// Use inbuilt intersection method and convert to array and return it.
/// </summary>
//int[] Intersection(int[] nums1, int[] nums2)
//{
//    var result = nums1.Intersect(nums2);

//    return result.ToArray();
//}

/// Create hashset and iterate through first array
/// Add all the elements to hash set
/// iterate through second array
/// check if hash set already has the element
/// if it is then add it to the list
/// finally do a distinct and convert to array and return it.
int[] Intersection(int[] nums1, int[] nums2)
{
    HashSet<int> set = new HashSet<int>();
    List<int> list = new List<int>();

    for (int i = 0; i < nums1.Length; i++)
    {
        set.Add(nums1[i]);
    }

    for (int i = 0; i < nums2.Length; i++)
    {
        if (set.Contains(nums2[i]))
        {
            list.Add(nums2[i]);
        }
    }

    return list.Distinct().ToArray();
}