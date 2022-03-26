// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x = 34532345;
IsPalindrome(x);

bool IsPalindrome(int x)
{
    if (x < 0)
    {
        return false;
    }

    string s = x.ToString();
    char[] reverse = s.ToCharArray();
    Array.Reverse(reverse);
    string temp = new string(reverse);
    if (s == temp)
    {
        return true;
    }

    return false;
}
