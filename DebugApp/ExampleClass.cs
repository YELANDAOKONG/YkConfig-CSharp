using YkConfig.Attributes;
using YkConfig.Provider;

namespace DebugApp;

[Serializable]
[ConfigClass]
public class ExampleClass
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }
    public List<string>? Hobbies { get; set; }
}