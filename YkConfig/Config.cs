using System.Runtime.Serialization;
using YkConfig.Provider;

namespace YkConfig;

public class Config<T>
{
    public string Path { get; set; }
    public IFileProvider Provider { get; set; }
    public bool Watch { get; set; }
    
    
    public Config(string path, IFileProvider provider, bool watch = false)
    {
        Path = path;
        Provider = provider;
        Watch = watch;
        
        if (!typeof(T).IsSerializable)
        {
            throw new SerializationException("config class must be serializable");
        }
    }
    
    
}