// See https://aka.ms/new-console-template for more information

using DebugApp;
using YkConfig;
using YkConfig.Provider.Default;

Console.WriteLine("Hello, World!");

ExampleClass example = new ExampleClass();
Config<ExampleClass> config = new Config<ExampleClass>(
    example,
    "example.json", 
    new JsonProvider(), 
    true
);

example.Name = "John";
example.Age = 20;
example.IsMarried = true;
example.Hobbies = new List<string>() { "Programming", "Gaming" };
config.Save();


