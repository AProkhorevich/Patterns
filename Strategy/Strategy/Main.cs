using Strategy.Ducks;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new SimpleDuck());
            ducks.Add(new AnyDuck());

            foreach(var duck in ducks)
            {
                duck.Display();
                duck.flightBehavior.Fly();
                duck.quackBehavior.Quack();
            }

            Console.Read();
        }
    }
}