using Microsoft.Extensions.Configuration;

namespace UITestAutomation
{
    internal class ConfigHelper
    {
        public static string GetConfig(string key)
        {
            ConfigurationBuilder configBuilder = new ConfigurationBuilder();
            IConfiguration cConfig = configBuilder.AddJsonFile("Appsettings.json",false,false).Build();
            var value = cConfig.GetRequiredSection("settings").GetSection(key).Value;
            return value;
        }
    }
}
