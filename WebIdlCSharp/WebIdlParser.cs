using Newtonsoft.Json;
using System.IO;

namespace WebIdlCSharp;

public static class WebIdlParser
{
    public static WebIdlTypeDefinition[] LoadTypesFromFile(string fileName)
    {
        var content = File.ReadAllText(fileName);
        var items = JsonConvert.DeserializeObject<WebIdlTypeDefinition[]>(content);
        return items;
    }
}
