namespace Solutions.Chapter1.Section3;

public static class S3
{
    public static bool AreBracketsBalanced(string brackets)
    {
        var stack = new Stack<char>();
        foreach (var bracket in brackets)
        {
            if (bracket == '{' || bracket == '[' || bracket == '(')
            {
                stack.Push(bracket);
            }
            else if (bracket == '}' || bracket == ']' || bracket == ')')
            {
                if (stack.Count == 0) return false;

                var topBracket = stack.Pop();
                if ((bracket == '}' && topBracket != '{') ||
                (bracket == ']' && topBracket != '[') ||
                (bracket == ')' && topBracket != '(')) return false;
            }
        }
        return stack.Count == 0;
    }
}