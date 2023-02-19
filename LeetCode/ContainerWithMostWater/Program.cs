// See https://aka.ms/new-console-template for more information

int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
MaxArea(height);
/// <summary>
/// Assign a variable to 0 to store result. 
/// Create two pointers left and right such that left to 0 and right to length - 1. 
/// do a while loop such that left < right; Calculate area; area = (right - left) * (Math.Min(height[left], height[right]) and 
/// after that get the max out of area and res; res = Math.Max(res, area); 
/// for navigating the pointers, check if(height[left] < height[right]), increment left; 
/// else if(height[left] > height[right]) right--; 
/// else if both are equal; decrement any pointer; 
/// after coming out of the loop, return res; 
/// Time Complexity -> O(n) and Space Complexity -> O(1) 
/// </summary>
int MaxArea(int[] height)
{
    int res = 0;
    int left = 0;
    int right = height.Length - 1;

    while(left < right)
    {
        int area = (right - left) * (Math.Min(height[left], height[right]));
        res = Math.Max(res, area);

        if(height[left] < height[right])
        {
            left++;
        }
        else
        {
            right--;
        }
    }

    return res;
}