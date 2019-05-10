# WebIDL parsing library in C#

Small library for parsing of WebIDL files and accessing their data from .NET application


```
using WebIdlCSharp;

var types = WebIdlParser.LoadTypesFromFile("vibration.json");
```

These JSON files could be generated using small NodeJS script from regular WebIDL files.

```
import webidl2 = require("webidl2");
import * as fs from "fs";

const content = fs.readFileSync(fileName);
const parsingStructure = webidl2.parse(content.toString());
fs.writeFileSync(outputFileName, JSON.stringify(parsingStructure, null, 2));

```
