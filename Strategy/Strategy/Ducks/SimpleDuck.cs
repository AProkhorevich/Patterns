using Strategy.Flight;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    class SimpleDuck : DuckBase
    {
        public SimpleDuck()
        {
            flightBehavior = new SimpleFlight();
            quackBehavior = new SimpleQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a SimpleDuck!");
        }
    }
}
