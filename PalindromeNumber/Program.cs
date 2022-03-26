// See https://aka.ms/new-console-template for more information
/// <summary>
/// convert int to string, string to char and use Array Reverse
/// </summary>
//int x = 34532345;

//IsPalindrome(x);

//bool IsPalindrome(int x)
//{
//    if (x < 0)
//    {
//        return false;
//    }

//    string s = x.ToString();
//    char[] reverse = s.ToCharArray();
//    Array.Reverse(reverse);
//    string temp = new string(reverse);
//    if (s == temp)
//    {
//        return true;
//    }

//    return false;
//}

/// <summary>
/// Inside while loop, use modulo operator, add to a list and 
/// divide the given number (then subsequent reminder) until it is 0
/// then compare the resulting array with the reversed array using SequenceEqual method
/// </summary>

ToDigitArray(121);
int[] ToDigitArray(int x)
{
    List<int> num = new List<int>();
    while (x != 0)
    {
        num.Add(x % 10);
        x = x / 10;
    }

    int[] givenNumber = num.ToArray();
    num.Reverse();
    int[] reverseNumber = num.ToArray();

    if (givenNumber.SequenceEqual(reverseNumber))
    {
        return givenNumber;
    }

    return reverseNumber;
}
