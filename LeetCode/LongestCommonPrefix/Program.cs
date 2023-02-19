
using System.Text;
/// <summary>
/// Takes the first element from string array and compares it against all the elements
/// using IndexOf operation. If it is not 0, it removes the last character using Substring operation
/// and continues until the IndexOf returns 0
/// Do this for all the susbequent elements in the array and return the Longest Common Prefix.
/// </summary>
string[] strs = { "flower", "flow", "flight" };

longestCommonPrefix(strs);
string longestCommonPrefix(string[] strs)
{
    if(strs.Length == 0)
    {
        return "";
    }

    string prefix = strs[0];
    for(int i = 1; i < strs.Length; i++)
    {
        while(strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (string.IsNullOrWhiteSpace(prefix)) return "";
        }
    }

    return prefix;
}

/// <summary>
/// Get the minimum length word from array using Math.Min()
/// Assign start and mid variable to 0 and end to min_length
/// While end >= start, pass string array and mid value to a function
/// In that function, get the substring value for first element in the string array (from 0 to mid value)
/// compare against other elements using for loop. If it doesn't start with the substring value return false, else return true.
/// return the prefix
/// </summary>
//String longestCommonPrefix(String[] strs)
//{
//    StringBuilder prefix = new StringBuilder();
//    if (strs == null || strs.Length == 0)
//    {
//        return "";
//    }
//    int min_length = int.MaxValue;
//    for (int index = 0; index < strs.Length; index++)
//    {
//        min_length = Math.Min(min_length, strs[index].Length);
//    }
//    int start = 0;
//    int mid = 0;
//    int end = min_length;
//    while (end >= start)
//    {
//        mid = (start + (end - start)) + 1 / 2;
//        if (commonPrefix(strs, mid))
//        {
//            prefix.Append(strs[0].Substring(start, mid));
//            start = mid + 1;
//        }
//        else end = mid - 1;

//    }
//    return prefix.ToString();

//}
//static bool commonPrefix(String[] strs, int mid)
// {
//    String s = strs[0].Substring(0, mid);
//    for (int index = 1; index < strs.Length; index++)
//    {
//        if (!strs[index].StartsWith(s))
//        {
//            return false;
//        }
//    }
//    return true;
//}

