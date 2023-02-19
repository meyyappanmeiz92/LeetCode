// See https://aka.ms/new-console-template for more information
/// <summary>
/// Get all the morse values inside a string array
/// initialise a list for adding the morse values
/// initialise result to 0
/// do a for loop on all the words that need to be calculated
/// then initailse a variable to empty string
/// do a for loop for each of the characters in a word
/// convert each character to corresponding ascii value using int
/// important point -> cs = cs + morse[c - 97] (offset for calculating the position inside morse array)
/// once we come out of the inner loop, check whether that particular morse element is inside the list
/// if it is there neglect it, otherwise add it to the list
/// increment the result counter and do until all the words are calculated
/// return the result
/// </summary>
string[] words = new string[] { "gin", "zen", "gig", "msg" };
uniqueMorseRepresentations(words);
int uniqueMorseRepresentations(string[] words)
{
    string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
    List<string> result = new List<string>();
    int ans = 0;
    for(int i = 0; i < words.Length; i++)
    {
        string cs = "";
        for(int j = 0; j < words[i].Length; j++)
        {
            int c = words[i][j];
            cs = cs + morse[c - 97];
        }
        if (!result.Contains(cs))
        {
            result.Add(cs);
            ans++;
        }
    }

    return ans;
}
