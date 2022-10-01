using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverage;
using Decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase bev = new Espresso();
            Print(bev);

            Console.WriteLine("_______");

            var capucino = new SugarCondiments(new MilkCondiments(new Espresso()));

            Print(capucino);

            Console.ReadKey();
        }

        static void Print(BeverageBase bev)
        {
            Console.WriteLine(String.Format("Напиток {0}; Цена {1}", bev.GetDescription(), bev.GetCost()));
        }
    }
}
