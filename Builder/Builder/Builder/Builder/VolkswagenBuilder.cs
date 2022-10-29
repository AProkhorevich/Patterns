using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder() : base()
        {
        }

        public override void BuildEngine()
        {
            car.Engine = "2.0 TFSI";
        }

        public override void BuildFrame()
        {
            car.Frame = "VW Frame";
        }

        public override void BuildLuxury()
        {
            car.Luxury = "VW Exclusive";
        }

        public override void BuildMultimedia()
        {
            car.Multimedia = "VW  Multimedia";
        }

        public override void BuildSafety()
        {
            car.Safety = "Side Assist";
        }

        public override void BuildWheels()
        {
            car.Wheels = "sliki ToyoTires";
        }
    }
}
