using ConsoleApp;
using PluginBase;

string[] pluginFolders = new string[]
{
    @"..\..\..\..\Plugin1\bin\Debug\netstandard2.1",
    @"..\..\..\..\Plugin2\bin\Debug\netstandard2.1"
};

var manager = new PluginManager<IPluginBase>();



Console.WriteLine("--- Without plugins ---");
foreach (var plugin in manager.GetImplementations())
    plugin.PrintData();

Console.WriteLine();



foreach(var pluginFolder in pluginFolders)
    manager.Load(pluginFolder);

Console.WriteLine("--- folders loaded ---");
foreach (var plugin in manager.GetImplementations())
    plugin.PrintData();

Console.WriteLine();



byte[] dllBytes = File.ReadAllBytes(@"..\..\..\..\Plugin3\bin\Debug\netstandard2.1\Plugin3.dll");
manager.Load(dllBytes);

Console.WriteLine("--- byte plugin loaded ---");
foreach (var plugin in manager.GetImplementations())
    plugin.PrintData();

Console.WriteLine();



var pluginToUnload = manager.Plugins.FirstOrDefault();
manager.Unload(pluginToUnload);

Console.WriteLine("--- unloaded plugin ---");
foreach (var plugin in manager.GetImplementations())
    plugin.PrintData();

Console.ReadLine();