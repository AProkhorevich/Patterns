﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Components
{
    class Leaf : Component
    {
        public override string Operation()
        {
            return "leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
