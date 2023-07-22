namespace SolutionTests;

[AttributeUsage(AttributeTargets.Method)]
public class ClientTestAttribute : Attribute
{
    public bool Hidden { get; }


    public ClientTestAttribute(bool hidden = false)
    {
        Hidden = hidden;
    }
}

