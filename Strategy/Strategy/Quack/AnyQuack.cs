using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Quack
{
    class AnyQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
