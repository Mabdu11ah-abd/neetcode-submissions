public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new();

        foreach( char c in s)
        {
            if(c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count == 0 )
                    return false;
                var parenthesis = stack.Pop();
                
                if(c == '}' && parenthesis != '{' || c == ')' && parenthesis != '(' || c == ']' && parenthesis != '[')
                {
                    return false;
                }
            }

        }
        if(stack.Count != 0)
        {
            return false;
        }
        return true;
    }
}
