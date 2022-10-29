using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base() { }

        public override void BuildEngine()
        {
            car.Engine = "2.0 TFSI";
        }

        public override void BuildFrame()
        {
            car.Frame = "Audi Frame";
        }

        public override void BuildLuxury()
        {
            car.Luxury = "Audi Exclusive";
        }

        public override void BuildMultimedia()
        {
            car.Multimedia = "Audi MMI Multimedia";
        }

        public override void BuildSafety()
        {
            car.Safety = "Side Assist";
        }

        public override void BuildWheels()
        {
            car.Wheels = "sliki Pirelli";
        }
    }
}
