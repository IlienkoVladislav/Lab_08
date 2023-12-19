using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            configManager.DisplaySettings();

            Console.WriteLine("Enter configuration settings. Type 'exit' to finish.");
            string key, value;

            do
            {
                Console.Write("Enter setting key: ");
                key = Console.ReadLine();

                if (key.ToLower() == "exit")
                    break;

                Console.Write("Enter setting value: ");
                value = Console.ReadLine();

                configManager.UpdateSetting(key, value);

            } while (true);

            configManager.SaveSettings();

            configManager.DisplaySettings();
        }
    }
}
