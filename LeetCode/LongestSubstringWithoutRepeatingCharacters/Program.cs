    /// <summary>
/// Initialize two pointers(i,j) to 0 and max to 0 as well
/// Initialize HashSet of chars and do the while loop until i is less s.length
/// Check each character is present in set, if not add it
/// If it is present, remove the element from jth pointer and increment until the condition is false
/// (i.e) when the ith pointer character is not present in the set.
/// After adding it to the set, compute the length of the longest substring
/// How we can do this is by computing Math.Max(max, i-j+1)
/// After we completed the iteration of the entire string, return max.
/// </summary>

string s = "SAIBABA";
LengthOfLongestSubstring(s);

int LengthOfLongestSubstring(string s)
{
    if(s == null || s.Length == 0)
    {
        return 0;
    }

    int i = 0, j = 0, max = 0;
    HashSet<char> set = new HashSet<char>();
    while(i < s.Length)
    {
        char c = s[i];
        while(set.Contains(c))
        {
            set.Remove(s[j]);
            j++;
        }
        set.Add(c);
        max = Math.Max(max, i - j + 1);
        i++;
    }

    return max;
}