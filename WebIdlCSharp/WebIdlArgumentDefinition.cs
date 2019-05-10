namespace WebIdlCSharp
{
    public class WebIdlArgumentDefinition : BaseWebIdlDefinition
    {
        public string Name { get; set; }
        public string EscapedName { get; set; }

        public WebIdlTypeReference IdlType { get; set; }
    }
}
