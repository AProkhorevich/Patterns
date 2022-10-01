using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Flight
{
    class SimpleFlight : IFlayable
    {
        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
