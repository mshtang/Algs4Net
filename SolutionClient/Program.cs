using SolutionTests;
using System.Reflection;

namespace SolutionClient;

class Program
{
    private const string Namespace = "SolutionTests";
    public static void Main(string[] args)
    {
        if (args.Length == 0 || args.Length == 1)
        {
            DisplayHelp();
            return;
        }

        var classNameParts = args[0].Split('.');
        var fullClassName = $"{Namespace}.Chapter{classNameParts[0]}.Section{classNameParts[1]}.S{classNameParts[2]}Tests";

        var assembly = Assembly.LoadFrom($"{Namespace}.dll");
        if (assembly == null)
        {
            Console.WriteLine("Make sure \"SolutionTests.dll\" is found in the working directory");
            return;
        }

        Type? testType = assembly.GetTypes()
            .FirstOrDefault(t => t.FullName == fullClassName);

        if (testType == null)
        {
            Console.WriteLine("The given solution number is not found.");
            return;
        }

        MethodInfo[] methods = testType.GetMethods()
            .Where(m => m.GetCustomAttributes(typeof(ClientTestAttribute), false)
                .Any(attr => ((ClientTestAttribute)attr).Hidden == false))
            .ToArray();

        MethodInfo? method = methods.FirstOrDefault(m => m.Name == args[1]);
        if (method == null)
        {
            Console.WriteLine("The method is not found or it is not meant for the test client. Check the method name is correct.");
            DisplayHelp();
            return;
        }

        try
        {
            if (args.Length == 2)
                method.Invoke(Activator.CreateInstance(testType), null);
            else
            {
                var testArgs = new string[args.Length - 2];
                for (var i = 2; i < args.Length; i++)
                    testArgs[i - 2] = args[i];
                method.Invoke(Activator.CreateInstance(testType), new object[] { testArgs });
            }
        }
        catch (System.Reflection.TargetParameterCountException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("The signature of the method is:");
            Console.WriteLine($"{method.GetSignature()}");
            return;
        }
    }

    private static void DisplayHelp()
    {
        var cmd = "SolutionClient";
        string[] helpText =
        {
        "\nUsage:\n",
        " " + cmd + " <chapter.section.exercise> <methodName> argument1 argument2 argument...\n"
        };

        foreach (var s in helpText)
        {
            Console.WriteLine(s);
        }
    }
}
