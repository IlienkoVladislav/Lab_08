using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class AbstractFactory
    {
        public abstract class Screen
        {
            public abstract void Display();
        }

        // Класи конкретних екранів
        public class SmartphoneScreen : Screen
        {
            public override void Display()
            {
                Console.WriteLine("Smartphone Screen");
            }
        }

        public class LaptopScreen : Screen
        {
            public override void Display()
            {
                Console.WriteLine("Laptop Screen");
            }
        }

        public class TabletScreen : Screen
        {
            public override void Display()
            {
                Console.WriteLine("Tablet Screen");
            }
        }

        // Абстрактний клас або інтерфейс для процесорів
        public abstract class Processor
        {
            public abstract void Process();
        }

        // Класи конкретних процесорів
        public class SmartphoneProcessor : Processor
        {
            public override void Process()
            {
                Console.WriteLine("Smartphone Processor");
            }
        }

        public class LaptopProcessor : Processor
        {
            public override void Process()
            {
                Console.WriteLine("Laptop Processor");
            }
        }

        public class TabletProcessor : Processor
        {
            public override void Process()
            {
                Console.WriteLine("Tablet Processor");
            }
        }

        // Абстрактний клас або інтерфейс для камер
        public abstract class Camera
        {
            public abstract void Capture();
        }

        // Класи конкретних камер
        public class SmartphoneCamera : Camera
        {
            public override void Capture()
            {
                Console.WriteLine("Smartphone Camera");
            }
        }

        public class LaptopCamera : Camera
        {
            public override void Capture()
            {
                Console.WriteLine("Laptop Camera");
            }
        }

        public class TabletCamera : Camera
        {
            public override void Capture()
            {
                Console.WriteLine("Tablet Camera");
            }
        }

        // Абстрактна фабрика для створення компонентів
        public abstract class TechProductFactory
        {
            public abstract Screen CreateScreen();
            public abstract Processor CreateProcessor();
            public abstract Camera CreateCamera();
        }

        // Класи конкретних фабрик
        public class SmartphoneFactory : TechProductFactory
        {
            public override Screen CreateScreen()
            {
                return new SmartphoneScreen();
            }

            public override Processor CreateProcessor()
            {
                return new SmartphoneProcessor();
            }

            public override Camera CreateCamera()
            {
                return new SmartphoneCamera();
            }
        }

        public class LaptopFactory : TechProductFactory
        {
            public override Screen CreateScreen()
            {
                return new LaptopScreen();
            }

            public override Processor CreateProcessor()
            {
                return new LaptopProcessor();
            }

            public override Camera CreateCamera()
            {
                return new LaptopCamera();
            }
        }

        public class TabletFactory : TechProductFactory
        {
            public override Screen CreateScreen()
            {
                return new TabletScreen();
            }

            public override Processor CreateProcessor()
            {
                return new TabletProcessor();
            }

            public override Camera CreateCamera()
            {
                return new TabletCamera();
            }
        }
    }
}
