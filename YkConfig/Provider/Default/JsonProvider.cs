using Newtonsoft.Json;

namespace YkConfig.Provider.Default;

public class JsonProvider : IFileProvider
{
    // 序列化选项
    public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings()
    {
        Formatting = Formatting.Indented,
    };
    
    public JsonProvider()
    {
        
    }
    
    public JsonProvider(JsonSerializerSettings serializerSettings)
    {
        SerializerSettings = serializerSettings;
    }
    
    public void Save(string path, object obj)
    {
        var file = File.CreateText(path);
        JsonSerializer serializer = new JsonSerializer();
        serializer.Formatting = SerializerSettings.Formatting;
        serializer.Serialize(file, obj);
        file.Close();
    }

    public object Load(string path)
    {
        return JsonConvert.DeserializeObject(File.ReadAllText(path));
    }
}