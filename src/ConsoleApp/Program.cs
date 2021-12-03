using ConsoleApp;
using PluginBase;

string[] plugins = new string[]
{
    @"...",
    @"..."
};

Type pluginType = typeof(IPluginBase);

List<PluginAssemblyLoadContext> contexts = new List<PluginAssemblyLoadContext>();
foreach (string pluginPath in plugins)
{
    PluginAssemblyLoadContext context = new PluginAssemblyLoadContext(pluginPath, pluginType);
    context.Initialize();

    contexts.Add(context);
}

foreach (var context in contexts)
    foreach (var plugin in context.GetImplementations<IPluginBase>())
        plugin.PrintData();

Console.ReadLine();