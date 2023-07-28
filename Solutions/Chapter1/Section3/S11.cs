namespace Solutions.Chapter1.Section3;

public static class S11
{
    public static string Evaluate(string infix)
    {
        var postfix = S10.ConvertInfixToPostfix(infix);
        var operands = new Stack<string>();

        foreach (var ch in postfix)
        {
            var tmp = ch.ToString();
            if (IsOperator(tmp))
            {
                var right = double.Parse(operands.Pop());
                var left = double.Parse(operands.Pop());
                var res = Operate(tmp, right, left);
                operands.Push(res);
            }
            else
            {
                operands.Push(tmp);
            }
        }
        return operands.Pop();
    }

    private static bool IsOperator(string ch) => "+-*/^%".Contains(ch);

    private static string Operate(string op, double right, double left)
    {
        var res = op switch
        {
            "+" => right + left,
            "-" => left - right,
            "*" => right * left,
            "/" => left / right,
            "^" => Math.Pow(left, right),
            "%" => left % right,
            _ => throw new ArgumentException($"I don't know how to deal with `${op}` as an operator!")
        };

        return res.ToString();
    }
}