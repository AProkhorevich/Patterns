using Strategy.Flight;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    class AnyDuck : DuckBase
    {
        public AnyDuck()
        {
            flightBehavior = new NoFlight();
            quackBehavior = new AnyQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm AnyDuck");
        }
    }
}
