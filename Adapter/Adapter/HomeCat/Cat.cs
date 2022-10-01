using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCat
{
    class Cat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Мяу.");
        }

        public void Sleep()
        {
            Console.WriteLine("Сплю.");
        }
    }
}
