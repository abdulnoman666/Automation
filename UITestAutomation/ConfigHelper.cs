using Microsoft.Extensions.Configuration;

namespace UITestAutomation
{
    internal class ConfigHelper
    {
        public static string GetConfig(string key)
        {
            var configBuilder = new ConfigurationBuilder();
            var cConfig = configBuilder.AddJsonFile("appsettings.json").Build();

            var value = cConfig.GetRequiredSection("settings").GetSection(key).Value;

            return value;
        }
    }
}
