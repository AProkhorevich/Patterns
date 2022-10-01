using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverage;

namespace Decorator.Decorators
{
    class MilkCondiments : CondimentsDecoratorBase
    {
        Beverage.BeverageBase _bevarage;

        public MilkCondiments(Beverage.BeverageBase beverage)
        {
            _bevarage = beverage;
            Description = _bevarage.GetDescription() + " +Milk";
        }

        public override double GetCost()
        {
            return _bevarage.GetCost() + 30;
        }
    }
}
