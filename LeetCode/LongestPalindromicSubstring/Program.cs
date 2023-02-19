// See https://aka.ms/new-console-template for more information
string s = "babad";
LongestPalindrome(s);

/// <summary>
/// Brute Force Approach, check for each character -> Time Complexity O(n3)
/// Optimal Solution, create two variables, one for storing palindrome string ("") and other for palindrome Length (0)
/// loop through the given string
/// for odd length string; assign left and right to i and for even length string; assign left to i and right to i + 1
/// do a while loop such that left greater than or equal to 0 and right less than given string length and s[l] == s[r]
/// check whether r - l + 1 > palindromeLength
/// if it is, then update the palindrome string with s.Substring(left, right - left + 1)
/// and update palindromeLength as well to right - left + 1
/// after coming out of while loop, do l-- and r++ to expand outwards to search for palindromic string
/// after coming out of for loop, return palindrome
/// </summary>
string LongestPalindrome(string s)
{
    string palindrome = "";
    int palindromeLength = 0;

    for(int i = 0; i < s.Length; i++)
    {
        //odd
        int left = i, right = i;
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            if(right - left + 1 > palindromeLength)
            {
                palindrome = s.Substring(left, right - left + 1);
                palindromeLength = right - left + 1;
            }

            left--;
            right++;
        }

        //even
        left = i; right = i + 1;
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            if (right - left + 1 > palindromeLength)
            {
                palindrome = s.Substring(left, right + 1);
                palindromeLength = right - left + 1; 
            }

            left--;
            right++;
        }
    }

    return palindrome;
}