// See https://aka.ms/new-console-template for more information
/// <summary>
/// Add all the keyboard row values to dictionary and mention the values as 1, 2, 3 based on which row they belong
/// initialise list
/// loop through all the words in the array and convert each word to lowercase
/// take the length of each word and get the corresponding row of first character from dictionary and assign it to row variable
/// Initialise bool variable called flag and assign it to true
/// initialise another forloop for each words in the array
/// get the row value from the dictionary for each character in the word and assign it to wordRow
/// compare the wordRow value with the row variable
/// if it matches then go to next character else set flag to false and break out of the loop
/// if all the character of a word matches with the row variable, then add the word to the list
/// Do the same steps for all the words in the array and add it to the list if condition satisfies
/// return list.ToArray()
/// </summary>
//string[] words = { "Hello","Alaska","Dad","Peace" };
//FindWords(words);
//string[] FindWords(string[] words)
//{
//    Dictionary<char, int> keyboardRow = new Dictionary<char, int>();
//    keyboardRow.Add('q', 1);
//    keyboardRow.Add('w', 1);
//    keyboardRow.Add('e', 1);
//    keyboardRow.Add('r', 1);
//    keyboardRow.Add('t', 1);
//    keyboardRow.Add('y', 1);
//    keyboardRow.Add('u', 1);
//    keyboardRow.Add('i', 1);
//    keyboardRow.Add('o', 1);
//    keyboardRow.Add('p', 1);

//    keyboardRow.Add('a', 2);
//    keyboardRow.Add('s', 2);
//    keyboardRow.Add('d', 2);
//    keyboardRow.Add('f', 2);
//    keyboardRow.Add('g', 2);
//    keyboardRow.Add('h', 2);
//    keyboardRow.Add('j', 2);
//    keyboardRow.Add('k', 2);
//    keyboardRow.Add('l', 2);

//    keyboardRow.Add('z', 3);
//    keyboardRow.Add('x', 3);
//    keyboardRow.Add('c', 3);
//    keyboardRow.Add('v', 3);
//    keyboardRow.Add('b', 3);
//    keyboardRow.Add('n', 3);
//    keyboardRow.Add('m', 3);

//    List<string> list = new List<string>();

//    for(int i = 0; i < words.Length; i++)
//    {
//        string word = words[i].ToLower();
//        int len = word.Length;
//        int row = keyboardRow.GetValueOrDefault(word[0]);

//        bool flag = true;
//        for(int j = 0; j < len; j++)
//        {
//            int wordRow = keyboardRow.GetValueOrDefault(word[j]);
//            if(wordRow != row)
//            {
//                flag = false;
//                break;
//            }
//        }

//        if (flag)
//        {
//            list.Add(words[i]);
//        }
//    }

//    return list.ToArray();
//}

///Initialise two lists: one for adding result and another for keyboard row
/// outer for loop for looping through all strings in the given array
/// convert each word to lower case and convert the resulting string to character array
/// in the inner for loop, loop through all the elements in the keyboardRow list
/// if char array arr matches with all the elements in any one of the keyboardRow list (arr.All(c => str.Contains(c)))
/// add that word to the result list and break out of the loop
/// if not then loop through remaining elements in the keyboardRow list
/// if it still doesn't match, then go to the next input word
/// finally return list.ToArray()
string[] words = { "Hello", "Alaska", "Dad", "Peace" };
FindWords(words);
string[] FindWords(string[] words)
{
    List<string> list = new List<string>();
    List<string> keyboardRow = new List<string>()
    {
        "qwertyuiop",
        "asdfghjkl",
        "zxcvbnm"
    };

    for(int i = 0; i < words.Length; i++)
    {
        char[] arr = words[i].ToLower().ToCharArray();
        foreach(var str in keyboardRow)
        {
            if(arr.All(c => str.Contains(c)))
            {
                list.Add(words[i]);
                break;
            }
        }
    }

    return list.ToArray();
}

