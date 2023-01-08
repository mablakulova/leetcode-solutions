namespace LeetCode;

public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> elements = new Stack<char>();

        foreach (char elem in s)
        {
            if(elem == '{' || elem == '(' || elem == '[')
                elements.Push(elem);
            else
            {
                if (elements.Count == 0) return false;
                if (elem == '}' && elements.Pop() != '{')
                    return false;
                if (elem == ')' && elements.Pop() != '(')
                    return false;
                if (elem == ']' && elements.Pop() != '[')
                    return false;
            }
        }

        return elements.Count == 0;
    }
}

