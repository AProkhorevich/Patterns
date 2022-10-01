using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    public class Espresso : BeverageBase
    {
        public Espresso()
        {
            Description = "strong coffe";
        }

        public override double GetCost()
        {
            return 150;
        }
    }
}
