using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCat
{
    class BritishCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Meow. Meow. Meow."); 
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep....");
        }
    }
}
