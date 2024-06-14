namespace YkConfig.Provider;

public interface IFileProvider
{
    void Save(string path, object obj);
    object Load(string path);
    
}