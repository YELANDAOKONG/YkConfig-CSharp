using YkConfig.Provider;

namespace YkConfig.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ConfigClassAttribute : Attribute
{
    public FileTypes Type { get; set; }
    public String? Path { get; set; }
    public ConfigClassAttribute()
    {
        
    }
    // public ConfigClassAttribute(FileTypes type)
    // {
    //     Type = type;
    // }
    //
    // public ConfigClassAttribute(String path, FileTypes type)
    // {
    //     Path = path;
    //     Type = type;
    // }

}