using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder.Factory
{
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder)
        {
        }

        public override Car Construct()
        {
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();
            carBuilder.BuildSafety();

            return carBuilder.GetCar();
        }
    }
}
