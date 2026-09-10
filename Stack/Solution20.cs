namespace LeetCode.Stack
{
    public class Solution20
    {
        public bool IsValid(string s)
        {
            Stack<char> closedBrackets = new Stack<char>();
            foreach(char bracket in s)
            {
                if(bracket == '(')
                {
                    closedBrackets.Push(')');
                }
                else if(bracket == '{')
                {
                    closedBrackets.Push('}');
                }
                else if(bracket == '[')
                {
                    closedBrackets.Push(']');
                }
                else if(closedBrackets.Count > 0)
                {
                    char storedBracket = closedBrackets.Peek();
                    if(storedBracket != bracket)
                    {
                        return false;
                    }
                    closedBrackets.Pop();
                }
                else
                {
                    return false;
                }
            }
            return closedBrackets.Count == 0;
        }
    }
}
