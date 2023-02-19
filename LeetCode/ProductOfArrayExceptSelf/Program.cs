// See https://aka.ms/new-console-template for more information
int[] nums = {1, 2, 3, 4};
ProductExceptSelf(nums);
/// <summary>
/// Initailse answer array
/// Initialise two arrays, left and right
/// Take into account all the elements to left (when doing left) and right (when doing right)
/// multiply both for answer array
/// </summary>
/// Time Complexity O(3n) => O(n)
/// Space Complexity O(2n) => O(n)
//int[] ProductExceptSelf(int[] nums)
//{
//    int len = nums.Length;
//    int[] answer = new int[len];

//    int[] left = new int[len];
//    int[] right = new int[len];

//    left[0] = 1;
//    for (int i = 1; i < len; i++)
//    {
//        left[i] = left[i - 1] * nums[i - 1];
//    }

//    right[len - 1] = 1;
//    for (int i = len - 2; i >= 0; i--)
//    {
//        right[i] = right[i + 1] * nums[i + 1];
//    }

//    for (int i = 0; i < len; i++)
//    {
//        answer[i] = left[i] * right[i];
//    }

//    return answer;
//}

/// Initialise Answer array
/// manipulate answer array with left side
/// create a variable for right and initialise to 1
/// do this logic, right = right * nums[i]
/// Time Complexity => O(2n) => O(n)
/// Space Complexity => O(1)
int[] ProductExceptSelf(int[] nums)
{
    int len = nums.Length;
    int[] answer = new int[len];

    answer[0] = 1;
    for (int i = 1; i < len; i++)
    {
        answer[i] = answer[i - 1] * nums[i - 1];
    }

    int right = 1;
    for (int i = len - 1; i >= 0; i--)
    {
        answer[i] = answer[i] * right;
        right = right * nums[i];
    }
    
    return answer;
}



