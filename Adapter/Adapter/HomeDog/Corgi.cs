using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeDog
{
    class Corgi : IHomeDog
    {
        public string NickName
        {
            get
            {
                return "Просто корги";
            }
        }

        public void Sleep()
        {
            Console.WriteLine("Сплю на спине");
        }

        public void Voice()
        {
            Console.WriteLine("Гав! Гав!");

        }
    }
}
