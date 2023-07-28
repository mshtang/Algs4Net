using Microsoft.VisualBasic;

namespace Solutions.Chapter1.Section3;

public static class S10
{
    public static string ConvertInfixToPostfix(string infix)
    {
        var operators = new Stack<string>();
        var res = "";
        foreach (var tmp in infix)
        {
            var ch = tmp.ToString();

            if (IsOperand(ch))
            {
                res += ch;
            }
            else if (ch == "(")
            {
                operators.Push(ch);
            }
            else if (ch == ")")
            {
                for (var i = 0; operators.Count > 0; i++)
                {
                    var tmp2 = operators.Pop();
                    if (tmp2 == "(") break;
                    res += tmp2;
                }
            }
            else if (IsOperator(ch))
            {
                while (operators.Count > 0 && operators.Peek() != "(" && GetPrecedence(ch) <= GetPrecedence(operators.Peek()))
                {
                    res += operators.Pop();
                }
                operators.Push(ch);
            }
        }

        while (operators.Count > 0)
        {
            res += operators.Pop();
        }

        return res;
    }

    private static bool IsOperand(string ch) => "0123456789".Contains(ch);

    private static bool IsOperator(string ch) => "+-*/^%".Contains(ch);

    private static int GetPrecedence(string ch)
    {
        return ch switch
        {
            "+" or "-" => 1,
            "*" or "/" => 2,
            "%" => 3,
            "^" => 4,
            _ => 0,
        };
    }
}