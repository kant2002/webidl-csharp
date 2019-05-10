using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebIdlCSharp
{
    public abstract class BaseWebIdlDefinition
    {
        public string Type { get; set; }
        public string Value { get; set; }

        public WebIdlTypeDefinition[] Values { get; set; }

        public WebIdlMemberDefinition[] Members { get; set; }

        [JsonExtensionData]
        internal IDictionary<string, JToken> ExtraStuff { get; set; }
    }
}
