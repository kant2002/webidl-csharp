namespace WebIdlCSharp;

public class WebIdlMemberDefinition : BaseWebIdlDefinition
{
    public string Name { get; set; }

    public WebIdlBodyDefinition Body { get; set; }

    public WebIdlTypeReference IdlType { get; set; }
}
