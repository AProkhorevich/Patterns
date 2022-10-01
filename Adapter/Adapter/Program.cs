using Adapter.Adapters;
using Adapter.HomeCat;
using Adapter.HomeDog;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IHomeCat bb = new Cat();
            bb.Name = "bb";
            PrintCatInfo(bb);

            IHomeDog corgi = new Corgi();
            PrintCatInfo(new HomeCatAdapter(corgi));

            Console.ReadKey();
        }

        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Информация о коте: ");
            Console.WriteLine(String.Format("Имя кота: {0}", cat.Name));
            Console.WriteLine("Звук: ");
            cat.Meow();
            cat.Sleep();
        }
    }
}
