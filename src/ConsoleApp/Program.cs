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

Console.WriteLine("--- After folders loaded ---");
foreach (var plugin in manager.GetImplementations())
    plugin.PrintData();

Console.WriteLine();



Console.ReadLine();