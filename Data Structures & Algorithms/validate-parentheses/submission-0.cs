public class Solution {
    public bool IsValid(string s) {
        if (s.Length <= 1)
        {
            return false;
        }
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>
        {
            { '}', '{'},
            { ']', '[' },
            { ')' , '(' }
        };
        foreach (var item in s)
        {
            if (pairs.ContainsKey(item))
            {
                if (stack.Peek() == pairs[item])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                stack.Push(item);
            }
            
        }
        return stack.Count == 0;
    }
}
