namespace WebIdlCSharp;

public class WebIdlBodyDefinition : BaseWebIdlDefinition
{
    public DetailedNameDescription Name { get; set; }

    public WebIdlTypeReference IdlType { get; set; }

    public WebIdlArgumentDefinition[] Arguments { get; set; }
}
