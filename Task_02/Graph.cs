using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
   
    public abstract class Graph
    {
        public abstract void Draw();
    }

    public class LineGraph : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Line Graph");
        }
    }

    public class BarGraph : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Bar Graph");
        }
    }

    public class PieChart : Graph
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Pie Chart");
        }
    }

    public abstract class GraphFactory
    {
        public abstract Graph CreateGraph();
    }

    public class LineGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new LineGraph();
        }
    }

    public class BarGraphFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new BarGraph();
        }
    }

    public class PieChartFactory : GraphFactory
    {
        public override Graph CreateGraph()
        {
            return new PieChart();
        }
    }
}
