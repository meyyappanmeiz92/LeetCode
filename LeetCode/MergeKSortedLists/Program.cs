// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

//uint n = 1100;

//reverseBits(n);
//reverseBits(uint n)
//{
//    uint res = 0;

//    // for(int i = 0; i < 32; i++){
//    //     res = res << 1;
//    //     res = res + n % 2;
//    //     n = n >> 1;
//    // }

//    // return res;

//    //for (int i = 0; i < 32; i++)
//    //{
//    //    uint bit = (n >> i) & 1;
//    //    res = res | (bit << (31 - i));
//    //}

//    //return res;

//    Console.WriteLine(n << )
//}

//Console.WriteLine(n << 1);

IsPalindrome("A man, a plan, a canal: Panama");

bool IsPalindrome(string s)
{
    //    s = s.ToLower();
    //    int l = 0;
    //    int r = s.Length - 1;

    //    while (l < r)
    //    {
    //        while (l < r && !IsAlphaNumeric(s[l]))
    //        {
    //            l++;
    //        }
    //        while (r > l && !IsAlphaNumeric(s[r]))
    //        {
    //            r--;
    //        }

    //        if (s[l] != s[r])
    //        {
    //            return false;
    //        }
    //    }

    //    return true;
    //}

    //bool IsAlphaNumeric(char c)
    //{
    //    return ((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'));

    //}

    s = s.ToLower();
    Regex rgx = new Regex("[^a-zA-Z0-9]");
    var newStr = rgx.Replace(s, "");
    char[] ch = newStr.ToCharArray();
    Array.Reverse(ch);
    var rev = new string(ch);

    return newStr == rev;
}

