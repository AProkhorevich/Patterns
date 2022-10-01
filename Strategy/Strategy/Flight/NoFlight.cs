using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Flight
{
    class NoFlight : IFlayable
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly! (");
        }
    }
}
