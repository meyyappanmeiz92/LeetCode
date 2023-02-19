/// <summary>
/// Initialize Stack and do a for loop on the characters in the string.
/// After that do a switch case on the open valid paranthesis.
/// and do a push of corresponding close brackets.
/// if none of the case match then in default check for stack empty or 
/// if popped element is not the current element in the loop
/// if one of the condition matches then return false
/// and after exiting the loop check for stack empty and return
/// </summary>

string s = "{}]";
isValid(s);
bool isValid(string s)
{
   Stack<char> stack = new Stack<char>();
   for (int i = 0; i < s.Length; i++)
   {
       char c = s[i];
       switch (c)
       {
            case '(':
                stack.Push(')');
                break;
            case '{':
                stack.Push('}');
                break;
            case '[':
                stack.Push(']');
                break;
            default:
                if (stack.Count == 0 || stack.Pop() != c)
                    return false;
                break;
                
       }
   }

   return stack.Count == 0;
}


