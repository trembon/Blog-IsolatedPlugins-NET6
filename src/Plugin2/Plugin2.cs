using PluginBase;

namespace Plugin2
{
    public class Plugin2 : IPluginBase
    {
        public void PrintData()
        {
            System.Console.WriteLine($"hello from Plugin2 (Newtonsoft version: {typeof(Newtonsoft.Json.JsonSerializer).Assembly.GetName().Version})");
        }
    }
}
