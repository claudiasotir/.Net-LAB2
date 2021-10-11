using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWeatherFunctions();
            Console.WriteLine();
            DoSoccerFunctions();

            Console.ReadKey();
        }

        private static void DoWeatherFunctions()
        {
            Weather weather = new Weather();
            weather.ReadData();
            //weather.PrintDataSet();
            Console.WriteLine(weather.GetValueWithMinDifference());
        }

        private static void DoSoccerFunctions()
        {
            Soccer soccer = new Soccer();
            soccer.ReadData();
            //soccer.PrintDataSet();
            Console.WriteLine(soccer.GetValueWithMinDifference());
        }
    }
}
