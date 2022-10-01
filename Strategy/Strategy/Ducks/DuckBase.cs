using Strategy.Flight;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Ducks
{
    public abstract class DuckBase
    {
        public IFlayable flightBehavior;
        public IQuackable quackBehavior;

        public DuckBase()
        {
            flightBehavior = new SimpleFlight();
            quackBehavior = new SimpleQuack();
        }

        public abstract void Display();
    }
}
