using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_04.Formats;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvDataTemplate = new CsvDataTemplate { CsvData = "1,John,Doe" };
            var xmlDataTemplate = new XmlDataTemplate { XmlData = "<Data><Id>1</Id><FirstName>John</FirstName><LastName>Doe</LastName></Data>" };
            var jsonDataTemplate = new JsonDataTemplate { JsonData = "{\"Id\":1,\"FirstName\":\"John\",\"LastName\":\"Doe\"}" };

            Console.WriteLine("Choose source data format (csv/xml/json): ");
            string sourceFormat = Console.ReadLine().ToLower();

            Console.WriteLine("Choose target data format (csv/xml/json): ");
            string targetFormat = Console.ReadLine().ToLower();

            IDataTemplate sourceData = null;

            switch (sourceFormat)
            {
                case "csv":
                    sourceData = csvDataTemplate;
                    break;
                case "xml":
                    sourceData = xmlDataTemplate;
                    break;
                case "json":
                    sourceData = jsonDataTemplate;
                    break;
                default:
                    Console.WriteLine("Invalid source data format");
                    return;
            }

            IDataAdapter adapter = null;

            switch (targetFormat)
            {
                case "csv":
                    Console.WriteLine("Conversion from CSV to CSV is not supported.");
                    return;
                case "xml":
                    adapter = new CsvToXmlAdapter();
                    break;
                case "json":
                    adapter = new CsvToXmlAdapter(); 
                    break;
                default:
                    Console.WriteLine("Invalid target data format");
                    return;
            }

            IDataTemplate targetData = adapter.Convert(sourceData);

            Console.WriteLine($"Converted data: {targetData}");
        }
    }
}
