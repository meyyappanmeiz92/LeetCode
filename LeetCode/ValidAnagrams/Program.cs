// See https://aka.ms/new-console-template for more information
string s = "anagram", t = "nagaram";

IsAnagram(s, t);
/// <summary>
/// String Problem -> Check whether two string lengths are equal, 
/// if it is not return false; Assign two dictionaries and do a for loop on on of the string lengths;
/// Add all the characters of s to a dictionary and add all the chars of t to another dictionary (dictionaryS[s[i]] = 1 + dictionaryS.GetValueOrDefault(s[i]); 
/// do another foreach loop on dictionaryS such that foreach(var c in dictionaryS) to compare two dictionary keys and values (if(dictionaryS.GetValueOrDefault(c.Key) != dictionaryT.GetValueOrDefault(c.Key)) return false. 
/// If it successfully crosses the loop, then return true Time Complexity -> O(s + t); Space Complexity -> O(s + t);; 
/// Another Approach -> sort all the chars in s and t and compare such that s.OrderBy(s => s).SequenceEqual(t.OrderBy(t => t)); 
/// Time Complexity -> O(nlogn) and Space Complexity O(1)
/// </summary>
bool IsAnagram(string s, string t)
{
    //if(s.Length != t.Length)
    //{
    //    return false;
    //}

    //Dictionary<char, int> dictionaryS = new Dictionary<char, int>();
    //Dictionary<char, int> dictionaryT = new Dictionary<char, int>();

    //for(int i = 0; i < s.Length; i++)
    //{
    //    dictionaryS[s[i]] = 1 + dictionaryS.GetValueOrDefault(s[i]);
    //    dictionaryT[t[i]] = 1 + dictionaryT.GetValueOrDefault(t[i]);
    //}

    //foreach(var c in dictionaryS)
    //{
    //    if(dictionaryT.GetValueOrDefault(c.Key) != dictionaryS.GetValueOrDefault(c.Key))
    //    {
    //        return false;
    //    }
    //}

    //return true;

    //Another Approach
    return s.OrderBy(s => s).SequenceEqual(t.OrderBy(t => t));
}