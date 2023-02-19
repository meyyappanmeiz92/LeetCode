string s = "aa";
string t = "aa";
MinWindow(s, t);

string MinWindow(string s, string t)
{
    if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t) ||
             s.Length < t.Length)
    {
        return "";
    }

    var window = new Dictionary<char, int>();
    var count = new Dictionary<char, int>();
    
    foreach (var c in t)
    {
        count[c] = 1 + count.GetValueOrDefault(c);
    }

    var need = count.Count;

    int l = 0;
    int resLeft = -1;
    int resRight = -1;
    int resLength = int.MaxValue;
    int have = 0;

    for (int r = 0; r < s.Length; r++)
    {
        window[s[r]] = 1 + window.GetValueOrDefault(s[r]);

        if (count.ContainsKey(s[r]) && window[s[r]] == count[s[r]])
        {
            have++;
        }

        while (have == need)
        {
            if (r - l + 1 < resLength)
            {
                resLeft = l;
                resRight = r;
                resLength = r - l + 1;
            }
            window[s[l]]--;

            if (count.ContainsKey(s[l]) && window[s[l]] < count[s[l]])
            {
                have--;
            }

            l++;
        }
    }

    return resLength != int.MaxValue ? s.Substring(resLeft, resLength) : "";
}
