using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_03.AbstractFactory;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a tech product (smartphone/laptop/tablet): ");
            string productType = Console.ReadLine().ToLower();

            TechProductFactory factory;

            switch (productType)
            {
                case "smartphone":
                    factory = new SmartphoneFactory();
                    break;
                case "laptop":
                    factory = new LaptopFactory();
                    break;
                case "tablet":
                    factory = new TabletFactory();
                    break;
                default:
                    Console.WriteLine("Invalid product type");
                    return;
            }

            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("Assembling tech product:");
            screen.Display();
            processor.Process();
            camera.Capture();
        }
    }
}
