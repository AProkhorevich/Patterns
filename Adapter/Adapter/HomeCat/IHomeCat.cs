﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.HomeCat
{
    interface IHomeCat
    {
        string Name { get; set; }
        void Meow();
        void Sleep();
    }
}
