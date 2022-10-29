using Builder.Builder;
using Builder.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cheap VW");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();

            Console.WriteLine(car.ToString());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Luxury VW");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();

            Console.WriteLine(car.ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Cheap Audi");
            constructor = new CheapCarFactory(new AudiBuilder());
            car = constructor.Construct();

            Console.WriteLine(car.ToString());

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Luxury Audi");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();

            Console.WriteLine(car.ToString());

            Console.ReadKey();
        }
    }
}
