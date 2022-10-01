using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    class SugarCondiments : CondimentsDecoratorBase
    {
        Beverage.BeverageBase _bevarage;

        public SugarCondiments(Beverage.BeverageBase beverage)
        {
            _bevarage = beverage;
            Description = _bevarage.GetDescription() + " +Sugar";
        }

        public override double GetCost()
        {
            return _bevarage.GetCost();
        }
    }
}
