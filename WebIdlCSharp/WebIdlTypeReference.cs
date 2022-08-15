using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebIdlCSharp;

public class WebIdlTypeReference : BaseWebIdlDefinition
{
    [JsonIgnore]
    public WebIdlTypeReference[] IdlType { get; set; }

    [JsonIgnore]
    public string TypeName { get; set; }

    public GenericInformation Generic { get; set; }

    [OnDeserialized]
    void OnDeserialize(StreamingContext streamingContext)
    {
        var idlType = this.ExtraStuff["idlType"];
        switch (idlType.Type)
        {
            case JTokenType.String:
                this.TypeName = idlType.Value<string>();
                break;
            case JTokenType.Array:
                this.IdlType = idlType.ToObject<WebIdlTypeReference[]>();
                break;
        }
    }
}
