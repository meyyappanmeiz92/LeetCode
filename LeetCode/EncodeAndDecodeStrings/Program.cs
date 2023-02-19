// See https://aka.ms/new-console-template for more information
List<string> input = new List<string> { "lint", "code" };
List<string> output = new List<string>() { "lint", "code" };
string str = "4#lint4#code";
Encode(input);
Decode(str);

/// <summary>
/// Encode:
/// Initialise empty string
/// and concatenate first length of string followed by a pound sign and the word
/// do the same for all the words
/// return that string
/// Decode:
/// Initialise list of strings and a pointer to 0
/// do a while loop for that string 
/// initialise another pointer j at i
/// do a while loop such that str[j] != '#', j++
/// if we found that char, come out of the loop and take the length out of that substring such that i, j - i
/// To decode first word from the string, do susbtring of j + 1, length
/// reset the i pointer to j + 1 + length so that it starts from next word and so on
/// return the list of strings
/// </summary>
string Encode(List<string> input)
{
    string str = "";
    for(int i = 0; i < input.Count; i++)
    {
        str = str + input[i].Length + "#" + input[i];
    }

    return str;
}


List<string> Decode(string str)
{
    var res = new List<string>();
    int i = 0;
    while(i < str.Length)
    {
        int j = i;
        while(str[j] != '#')
        {
            j++;
        }

        int length = Convert.ToInt32(str.Substring(i, j - i));
        res.Add(str.Substring(j + 1, length));
        i = j + 1 + length;
    }

    return res;
}

int i = 1;
do
{
    i++;
} while (i < 5);

Console.WriteLine(i);

int j = 1;
while(j < 5)
{
    j++;
}

Console.WriteLine(j);