using System.Runtime.Serialization;
using YkConfig.Provider;

namespace YkConfig;

public class Config<T>
{
    public string Path { get; set; }
    public IFileProvider Provider { get; set; }
    public bool Watch { get; set; }
    public T ClassObject { get; set; }
    
    
    public Config(T obj, string path, IFileProvider provider, bool watch = false)
    {
        Path = path;
        Provider = provider;
        Watch = watch;
        ClassObject = obj;
        if (ClassObject == null)
        {
            throw new ArgumentNullException("config object cannot be null");
        }
        
        if (!ClassObject.GetType().IsSerializable)
        {
            throw new SerializationException("config class must be serializable");
        }
    }
    
    public void Load()
    {
        ClassObject = (T)Provider.Load(Path);
    }
    
    public void Save()
    {
        Provider.Save(Path, (object)ClassObject);
    }

    public T Get()
    {
        return ClassObject;
    }
    
    
}