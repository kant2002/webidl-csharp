namespace WebIdlCSharp;

public class WebIdlTypeDefinition : BaseWebIdlDefinition
{
    public string Name { get; set; }

    public WebIdlTypeReference IdlType { get; set; }

    public WebIdlArgumentDefinition[] Arguments { get; set; }
}
