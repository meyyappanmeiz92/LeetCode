// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

CharacterReplacement("AABABBA", 1);
int CharacterReplacement(string s, int k)
{
    var c = int.MaxValue;
    var count = new Dictionary<char, int>();
    int res = 0;
    int l = 0;
    for (int r = 0; r < s.Length; r++)
    {
        count[s[r]] = 1 + count.GetValueOrDefault(s[r]);
        Console.WriteLine(count[s[r]]);
        while (((r - l + 1) - count.Values.Max()) > k)
        {
            count[s[l]]--;
            l--;
        }
        res = Math.Max(res, r - l + 1);
    }

    return res;
}
