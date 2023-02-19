/// <summary>
/// Get the length of the array and point to the last element and start navigating using while loop
/// if the element is 9, replace that with 0 else
/// increase by 1 and return it.
/// if it exits the while loop, then initialize an array with 1 length higher and
/// make the first element 1 and return it.(since it will be all 0 by default)
/// </summary>

int[] digits = { 7, 9, 8, 9 };
PlusOne(digits);
int[] PlusOne(int[] digits)
{
    int length = digits.Length;
    int i = length - 1;
    while(i >= 0)
    {
        if(digits[i] == 9)
        {
            digits[i] = 0;
        }

        else
        {
            digits[i] = digits[i] + 1;
            return digits;
        }

        i--;
    }

    int[] result = new int[length + 1];
    result[0] = 1;

    return result;
}
