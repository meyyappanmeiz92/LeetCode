// See https://aka.ms/new-console-template for more information
/// <summary>
/// Initialise Dictionary with char and int and add all roman values and their equivalent int value to dictionary
/// assign sum = 0
/// loop through all elements in string
/// if i < s.Length - 1 and romanValues.GetValueOrDefault(s[i]) < romanValues.GetValueOrDefault(s[i+1])
/// do sum = sum - romanValues.GetValueOrDefault(s[i])
/// else
/// do sum = sum + romanValues.GetValueOrDefault(s[i])
/// return sum
/// </summary>
RomanToString("MCMXCIV");
int RomanToString(string s)
{
    Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
       {'I', 1 },
       {'V', 5 },
       {'X', 10 },
       {'L', 50 },
       {'C', 100 },
       {'D', 500 },
       {'M', 1000 }
    };

    int sum = 0;
    for(int i = 0; i < s.Length; i++)
    {
        if(i < s.Length - 1 && romanValues.GetValueOrDefault(s[i]) < romanValues.GetValueOrDefault(s[i + 1]))
        {
            sum = sum - romanValues.GetValueOrDefault(s[i]);
        }
        else
        {
            sum = sum + romanValues.GetValueOrDefault(s[i]);
        }
    }

    return sum;
}

