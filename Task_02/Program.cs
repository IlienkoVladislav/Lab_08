using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of graph (line/bar/pie): ");
            string graphType = Console.ReadLine().ToLower();

            GraphFactory graphFactory;

            switch (graphType)
            {
                case "line":
                    graphFactory = new LineGraphFactory();
                    break;
                case "bar":
                    graphFactory = new BarGraphFactory();
                    break;
                case "pie":
                    graphFactory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Invalid graph type");
                    return;
            }

            Graph graph = graphFactory.CreateGraph();
            graph.Draw();
        }
    }
}
