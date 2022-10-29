using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Factory
{
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase carBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            carBuilder = builder;
        }

        public abstract Car Construct();
    }
}
