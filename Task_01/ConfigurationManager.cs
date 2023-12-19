using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private Dictionary<string, string> configurationSettings;

        private ConfigurationManager()
        {
            configurationSettings = new Dictionary<string, string>();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public void DisplaySettings()
        {
            foreach (var setting in configurationSettings)
            {
                Console.WriteLine($"{setting.Key}: {setting.Value}");
            }
        }

        public void UpdateSetting(string key, string value)
        {
            if (configurationSettings.ContainsKey(key))
            {
                configurationSettings[key] = value;
            }
            else
            {
                configurationSettings.Add(key, value);
            }
        }

        public void SaveSettings()
        {
            Console.WriteLine("Configuration settings saved.");
        }
    }
}
