// See https://aka.ms/new-console-template for more information
/// initialise max to min integer value and count to 0
/// loop through all elements in the array
/// if it is 1, increment count
/// else take Math.Max(count, max) and assign it to max and reset count to 0
/// After looping through all elements return Math.Max(max, count)
int[] nums = { 1, 0, 1, 1, 0, 1, 1, 1 };
FindMaxConsecutiveOnes(nums);
int FindMaxConsecutiveOnes(int[] nums)
{
    int max = int.MinValue;
    int count = 0;
    foreach(var num in nums)
    {
        if(num == 1)
        {
            count++;
        }
        else
        {
            max = Math.Max(max, count);
            count = 0;
        }
    }

    return Math.Max(max, count);
}
