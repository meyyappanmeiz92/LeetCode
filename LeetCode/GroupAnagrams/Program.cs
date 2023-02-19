// See https://aka.ms/new-console-template for more information

string[] strs = { "" };

GroupAnagrams(strs);
/// <summary>
/// Initialise Dictionary with string as key and List<string> as value
/// 
/// Time Complexity -> O(mn) and Space Complexity -> O(m)
/// </summary>
IList<IList<string>> GroupAnagrams(string[] strs)
{
    var dictionary = new Dictionary<string, List<string>>();

    for (int i = 0; i < strs.Length; i++)
    {
        int[] count = new int[26];
        for (int j = 0; j < strs[i].Length; j++)
        {
            count[strs[i][j] - 'a']++;
        }

        var s = string.Join(" ", count);
        
        if (dictionary.ContainsKey(s))
        {
            dictionary[s].Add(strs[i]);
        }
        else
        {
            dictionary.Add(s, new List<string> { strs[i] });
        }
    }

    var x = dictionary.Values;

    //var res = new List<IList<string>>(x);

    //var c = new List<IList<string>>
    //{
    //    new List<string>
    //    {
    //        x[0]
    //    }
    //};

    //return res;

    return null;

}

List<string> example()
{
    var list = new List<string>()
    {
        "abc","def"
    };
    return new List<string>(list);
}