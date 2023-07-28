namespace Solutions.Chapter1.Section3;

public static class S9
{
    public static string ConvertToInfix(string expression)
    {
        var operands = new Stack<string>();
        var operators = new Stack<string>();
        foreach (var ch in expression)
        {
            if (ch == '(')
            {

            }
            else if (ch == '+' || ch == '-' || ch == '*' || ch == '/')
            {
                operators.Push(ch.ToString());
            }
            else if (ch == ')')
            {
                var val2 = operands.Pop();
                var val1 = operands.Pop();
                var op = operators.Pop();
                var subExpression = $"({val1}{op}{val2})";
                operands.Push(subExpression);
            }
            else
            {
                operands.Push(ch.ToString());
            }
        }
        return operands.Pop();
    }
}